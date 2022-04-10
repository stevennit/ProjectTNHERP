using Hiver.Application.Catalog.Partners;
using Hiver.Application.Common;
using Hiver.Data.EF;
using Hiver.Data.Entities;
using Hiver.Utilities.Exceptions;
using Hiver.ViewModels.Catalog.Partners;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Catalog.Partners
{
    public class PartnerService : IPartnerService
    {
        private readonly HiverDbContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "/Files/Images/Partner";
        public PartnerService(HiverDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }
        public async Task<Guid> Create(PartnerCreateRequest request)
        {
            var table = new Partner()
            {
                Name = request.Name,
                Gender = request.Gender,
                Mobile = request.Mobile,
                Email = request.Email,
                Description = request.Description,
                Detail = request.Detail,
                Image = await this.SaveFile(request.Image),
                DoB = request.DoB,
                CreateDate = request.CreateDate.ToString() != null ? request.CreateDate : DateTime.Now,
                CreateBy = request.CreateBy,
                Status = request.Status.ToString() != null ? request.Status : (Utilities.Enums.Status.Active)
            };

            _context.Partners.Add(table);
            await _context.SaveChangesAsync();

            return table.Id;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            if (file != null)
            {
                var originalFileName = USER_CONTENT_FOLDER_NAME + ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
                var fullfilename = USER_CONTENT_FOLDER_NAME + fileName;
                await _storageService.SaveFileAsync(file.OpenReadStream(), USER_CONTENT_FOLDER_NAME, fullfilename);
                return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
            }
            return "";
        }


        public async Task<Guid> Delete(Guid Id)
        {
            var table = await _context.Partners.FindAsync(Id);
            if (table == null) throw new HiverException($"Không tìm được nhà cung cấp : {Id}");

            _context.Partners.Remove(table);

            await _context.SaveChangesAsync();

            return table.Id;
        }

        public async Task<PagedResult<PartnerVm>> GetAllPaging(GetPartnerPagingRequest request)
        {

            var query = from a in _context.PartnerCategories select a;
            //1. ƯQ filter
            if (!string.IsNullOrEmpty(request.Keyword))
               query = query.Where(x => x.Name.Contains(request.Keyword));

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new PartnerVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Mobile = x.Mobile,
                    Email = x.Email,
                    Description = x.Description,
                    Image = x.Image,
                    CreateDate = x.CreateDate,
                    CreateBy = x.CreateBy,
                    ModifyDate = x.ModifyDate,
                    ModifyBy = x.ModifyBy,
                    Status = x.Status

                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<PartnerVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<PartnerVm> GetById(Guid Id)
        {
            var table = await _context.Partners.FindAsync(Id);

            if (table == null) throw new HiverException($"Không tìm được sản phẩm : {Id}");

            var tableViewModel = new PartnerVm()
            {
                Id = table.Id,
                Name = table.Name,
                Gender = table.Gender,
                Description = table.Description,
                Detail = table.Detail,
                CreateDate = table.CreateDate,
                CreateBy = table.CreateBy,
                ModifyDate = table.ModifyDate,
                ModifyBy = table.ModifyBy,
                Status = table.Status,
                Image = table.Image != null ? table.Image : "no-image.jpg"
            };
            return tableViewModel;
        }

        public async Task<Guid> Update(PartnerUpdateRequest request)
        {
            var table = await _context.Partners.FindAsync(request.Id);

            table.Name = request.Name;
            table.Gender = request.Gender;
            table.Description = request.Description;
            table.Detail = request.Detail;
            table.Image = request.Image;
            table.DoB = request.DoB;
            table.ModifyDate = DateTime.Now;
            table.ModifyBy = request.ModifyBy;
            table.Status = request.Status;

            _context.Partners.Update(table);

            await _context.SaveChangesAsync();

            return table.Id;
        }
    }
}
