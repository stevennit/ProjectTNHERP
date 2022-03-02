﻿using Hiver.Application.Common;
using Hiver.Data.EF;
using Hiver.Data.Entities;
using Hiver.Utilities.Exceptions;
using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Catalog.ProductCategories
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly HiverDbContext _context;

        public ProductCategoryService(HiverDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ProductCategoryCreateRequest request)
        {
            var table = new ProductCategory()
            {
                Name = request.Name,
                Description = request.Description,
                Image = request.Image,
                CreateBy = request.CreateBy,
                Status = request.Status
            };

            _context.ProductCategories.Add(table);
            await _context.SaveChangesAsync();

            return table.Id;
        }

        public async Task<int> Delete(int Id)
        {
            var table = await _context.ProductCategories.FindAsync(Id);
            if (table == null) throw new HiverException($"Không tìm thấy loại tem: {Id}");

            _context.ProductCategories.Remove(table);

            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductCategoryViewModel>> GetAllPaging(GetPublicProductCategoryPagingRequest request)
        {
            // 1.Select join
            var query = from c in _context.ProductCategories
                        select new { c };
            //2. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductCategoryViewModel()
                {
                    Id = x.c.Id,
                    Name = x.c.Name,
                    Description = x.c.Description,
                    Image = x.c.Image,
                    CreateBy = x.c.CreateBy,
                    CreateDate = x.c.CreateDate,
                    ModifyBy = x.c.ModifyBy,
                    ModifyDate = x.c.ModifyDate,
                    Status = x.c.Status
                }).ToListAsync();

            //3. Select and projection
            var pagedResult = new PagedResult<ProductCategoryViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ProductCategoryViewModel> GetById(int Id)
        {
            var query = from c in _context.ProductCategories
                        where  c.Id == Id
                        select new { c };

            return await query.Select(x => new ProductCategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.c.Name,
                Description = x.c.Description,
                Image = x.c.Image,
                CreateBy = x.c.CreateBy,
                CreateDate = x.c.CreateDate,
                ModifyBy = x.c.ModifyBy,
                ModifyDate = x.c.ModifyDate,
                Status = x.c.Status

            }).FirstOrDefaultAsync();
        }

        public async Task<int> Update(ProductCategoryUpdateRequest request)
        {
            var table = await _context.ProductCategories.FindAsync(request.Id);

            if (table == null) throw new HiverException($"Không tìm thấy loại tem: {request.Id}");

            table.Id = request.Id;
            table.Name = request.Name;
            table.Description = request.Description;
            table.Image = request.Image;
            table.ModifyBy = request.ModifyBy;
            table.Status = request.Status;

            return await _context.SaveChangesAsync();
        }

    }
}
