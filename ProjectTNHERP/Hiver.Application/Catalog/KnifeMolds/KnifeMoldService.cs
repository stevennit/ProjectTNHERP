using Hiver.Application.Common;
using Hiver.Data.EF;
using Hiver.Data.Entities;
using Hiver.Utilities.Exceptions;
using Hiver.ViewModels.Catalog.KnifeMoldImages;
using Hiver.ViewModels.Catalog.KnifeMolds;
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

namespace Hiver.Application.Catalog.KnifeMolds
{
    public class KnifeMoldService : IKnifeMoldService
    {
        private readonly HiverDbContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "files";

        public KnifeMoldService(HiverDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> AddImage(int tableId, KnifeMoldImageCreateRequest request)
        {
            var tableImage = new KnifeMoldImage()
            {
                Caption = request.Caption,
                DateCreated = DateTime.Now,
                IsDefault = request.IsDefault,
                IdTable = tableId,
                SortOrder = request.SortOrder
            };

            if (request.ImageFile != null)
            {
                tableImage.ImagePath = await this.SaveFile(request.ImageFile);
                tableImage.FileSize = request.ImageFile.Length;
            }
            _context.KnifeMoldImages.Add(tableImage);
            await _context.SaveChangesAsync();
            return tableImage.Id;
        }

        public async Task<int> Create(KnifeMoldCreateRequest request)
        {
            var table = new KnifeMold()
            {
                Name = request.Name,
                Width = request.Width,
                Height = request.Height,
                Row = request.Row,
                Description = request.Description,
                Detail = request.Detail,
                CreateBy = request.CreateBy,
                CreateDate = DateTime.UtcNow,
                Status = request.Status
            };

            //Save image
            if (request.ThumbnailImage != null)
            {
                table.KnifeMoldImages = new List<KnifeMoldImage>()
                {
                    new KnifeMoldImage()
                    {
                        Caption = "Thumbnail image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
            }
            _context.KnifeMolds.Add(table);
            await _context.SaveChangesAsync();
            return Convert.ToInt32(table.Id);
        }

        public async Task<int> Delete(int Id)
        {
            var table = await _context.KnifeMolds.FindAsync(Id);
            if (table == null) throw new HiverException($"Không tìm được sản phẩm : {Id}");

            var images = _context.KnifeMoldImages.Where(i => i.IdTable == Id);

            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.KnifeMolds.Remove(table);

            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<KnifeMoldVm>> GetAllPaging(GetAllKnifeMoldPagingRequest request)
        {
            //1. Select join
            var query = from t0 in _context.KnifeMolds
                        join t2 in _context.KnifeMoldCategories on t0.IdKnifeMoldCategory equals t2.Id into temp2
                        from t2 in temp2.DefaultIfEmpty()
                        join t3 in _context.KnifeMoldImages on t0.Id equals t3.IdTable into temp3
                        from t3 in temp3.DefaultIfEmpty()
                        select new { t0, t2, t3 };
            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.t2.Name.Contains(request.Keyword));

            if (request.CategoryId != null || request.CategoryId != 0)
            {
                query = query.Where(p => p.t2.Id == request.CategoryId);
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new KnifeMoldVm()
                {
                    Id = x.t0.Id,
                    Name = x.t0.Name,
                    Width = x.t0.Width,
                    Height = x.t0.Height,
                    Description = x.t0.Description,
                    Detail = x.t0.Detail,
                    CreateDate = x.t0.CreateDate,
                    CreateBy = x.t0.CreateBy,
                    ModifyDate = x.t0.ModifyDate,
                    ModifyBy = x.t0.ModifyBy,
                    Status = x.t0.Status,
                    ThumbnailImage = x.t3.ImagePath
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<KnifeMoldVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<KnifeMoldVm> GetById(int Id)
        {
            var table = await _context.KnifeMolds.FindAsync(Id);

            if (table == null) throw new HiverException($"Không tìm được sản phẩm : {Id}");

            var image = await _context.KnifeMoldImages.Where(x => x.IdTable == Id && x.IsDefault == true).FirstOrDefaultAsync();

            var tableViewModel = new KnifeMoldVm()
            {
                Id = table.Id,
                Name = table.Name,
                Width = table.Width,
                Height = table.Height,
                Description = table.Description,
                Detail = table.Detail,
                CreateDate = table.CreateDate,
                CreateBy = table.CreateBy,
                ModifyDate = table.ModifyDate,
                ModifyBy = table.ModifyBy,
                Status = table.Status,
                ThumbnailImage = image != null ? image.ImagePath : "no-image.jpg"
            };
            return tableViewModel;
        }

        public async Task<KnifeMoldImageVm> GetImageById(int imageId)
        {
            var image = await _context.KnifeMoldImages.FindAsync(imageId);
            if (image == null)
                throw new HiverException($"Không tìm thấy ảnh {imageId}");

            var viewModel = new KnifeMoldImageVm()
            {
                Caption = image.Caption,
                DateCreated = image.DateCreated,
                FileSize = image.FileSize,
                Id = image.Id,
                ImagePath = image.ImagePath,
                IsDefault = image.IsDefault,
                IdTable = image.IdTable,
                SortOrder = image.SortOrder
            };
            return viewModel;
        }

        public async Task<List<KnifeMoldImageVm>> GetListImages(int tableId)
        {
            return await _context.KnifeMoldImages.Where(x => x.IdTable == tableId)
                .Select(i => new KnifeMoldImageVm()
                {
                    Caption = i.Caption,
                    DateCreated = i.DateCreated,
                    FileSize = i.FileSize,
                    Id = i.Id,
                    ImagePath = i.ImagePath,
                    IsDefault = i.IsDefault,
                    IdTable = i.IdTable,
                    SortOrder = i.SortOrder
                }).ToListAsync();
        }

        public async Task<int> RemoveImage(int imageId)
        {
            var tableImage = await _context.ProductImages.FindAsync(imageId);
            if (tableImage == null)
                throw new HiverException($"Không tìm được ảnh {imageId}");
            _context.ProductImages.Remove(tableImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(KnifeMoldUpdateRequest request)
        {
            var table = await _context.Products.FindAsync(request.Id);

            table.Name = request.Name;
            table.Width = request.Width;
            table.Height = request.Height;
            table.Description = request.Description;
            table.Detail = request.Detail;
            table.ModifyDate = DateTime.Now;
            table.ModifyBy = request.ModifyBy;
            table.Status = request.Status;

            //Save image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.KnifeMoldImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.IdTable == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.KnifeMoldImages.Update(thumbnailImage);
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateImage(int imageId, KnifeMoldImageUpdateRequest request)
        {
            var tableImage = await _context.KnifeMoldImages.FindAsync(imageId);

            if (tableImage == null)
                throw new HiverException($"Không thể tìm được ảnh {imageId}");

            if (request.ImageFile != null)
            {
                tableImage.ImagePath = await this.SaveFile(request.ImageFile);
                tableImage.FileSize = request.ImageFile.Length;
            }
            _context.KnifeMoldImages.Update(tableImage);
            return await _context.SaveChangesAsync();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = USER_CONTENT_FOLDER_NAME + ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            var fullfilename = USER_CONTENT_FOLDER_NAME + fileName;
            await _storageService.SaveFileAsync(file.OpenReadStream(), fullfilename);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }
    }
}
