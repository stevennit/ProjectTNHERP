﻿using Hiver.Application.Common;
using Hiver.Data.EF;
using Hiver.Data.Entities;
using Hiver.Utilities.Exceptions;
using Hiver.ViewModels.Catalog.ProductImages;
using Hiver.ViewModels.Catalog.Products;
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

namespace Hiver.Application.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly HiverDbContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "files";

        public ProductService(HiverDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request)
        {
            //1. Select join
            var query = from t0 in _context.Products
                        join t1 in _context.ProductAndProductCategories on t0.Id equals t1.IdProduct into temp1
                        from t1 in temp1.DefaultIfEmpty()
                        join t2 in _context.ProductCategories on t1.IdProductCategory equals t2.Id into temp2
                        from t2 in temp2.DefaultIfEmpty()
                        join t3 in _context.ProductImages on t0.Id equals t3.ProductId into temp3
                        from t3 in temp3.DefaultIfEmpty()
                        select new { t0, t1, t2 ,t3};
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
                .Select(x => new ProductVm()
                {
                    Id = x.t0.Id,
                    Name = x.t0.Name,
                    Symbol = x.t0.Symbol,
                    Width = x.t0.Width,
                    Height = x.t0.Height,
                    Description = x.t0.Description,
                    Detail = x.t0.Detail,
                    CreateDate = x.t0.CreateDate,
                    CreateBy = x.t0.CreateBy,
                    ModifyDate = x.t0.ModifyDate,
                    ModifyBy = x.t0.ModifyBy,
                    Status = x.t0.Status,
                    ViewCount = x.t0.ViewCount,
                    ThumbnailImage = x.t3.ImagePath
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ProductVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ProductVm> GetById(int Id)
        {
            var product = await _context.Products.FindAsync(Id);

            if (product == null) throw new HiverException($"Không tìm được sản phẩm : {Id}");

            var image = await _context.ProductImages.Where(x => x.ProductId == Id && x.IsDefault == true).FirstOrDefaultAsync();

            var productViewModel = new ProductVm()
            {
                Id = product.Id,
                Name = product.Name,
                Symbol = product.Symbol,
                Width = product.Width,
                Height = product.Height,
                Description = product.Description,
                Detail = product.Detail,
                CreateDate = product.CreateDate,
                CreateBy = product.CreateBy,
                ModifyDate = product.ModifyDate,
                ModifyBy = product.ModifyBy,
                Status = product.Status,
                ViewCount = product.ViewCount,
                ThumbnailImage = image != null ? image.ImagePath : "no-image.jpg"
            };
            return productViewModel;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var checkSymbol = _context.Products.Where(x => x.Symbol == request.Symbol).FirstOrDefault();

            if (checkSymbol != null) throw new HiverException($"Ký hiệu này đã tồn tại  : {request.Symbol}");

            var product = new Product()
            {
                Name = request.Name,
                Symbol = request.Symbol,
                Width = request.Width,
                Height = request.Height,
                Description = request.Description,
                Detail = request.Detail,
                CreateBy = request.CreateBy,
                CreateDate = DateTime.UtcNow,
                Status = (Utilities.Enums.Status)request.Status
            };
            //Save image
            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
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
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new HiverException($"Không tìm được sản phẩm : {productId}");

            var images = _context.ProductImages.Where(i => i.ProductId == productId);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.Products.Remove(product);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);

            product.Name = request.Name;
            product.Symbol = request.Symbol;
            product.Width = request.Width;
            product.Height = request.Height;
            product.Description = request.Description;
            product.Detail = request.Detail;
            product.ModifyDate = DateTime.Now;
            product.ModifyBy = request.ModifyBy;
            product.Status = request.Status;

            //Save image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.ProductImages.Update(thumbnailImage);
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task AddViewcount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = USER_CONTENT_FOLDER_NAME +  ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            var fullfilename = USER_CONTENT_FOLDER_NAME + fileName;
            await _storageService.SaveFileAsync(file.OpenReadStream(), fullfilename);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }

        public async Task<int> AddImage(int tableId, ProductImageCreateRequest request)
        {
            var productImage = new ProductImage()
            {
                Caption = request.Caption,
                DateCreated = DateTime.Now,
                IsDefault = request.IsDefault,
                ProductId = tableId,
                SortOrder = request.SortOrder
            };

            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Add(productImage);
            await _context.SaveChangesAsync();
            return productImage.Id;
        }

        public async Task<ProductImageViewModel> GetImageById(int imageId)
        {
            var image = await _context.ProductImages.FindAsync(imageId);
            if (image == null)
                throw new HiverException($"Không tìm thấy ảnh {imageId}");

            var viewModel = new ProductImageViewModel()
            {
                Caption = image.Caption,
                DateCreated = image.DateCreated,
                FileSize = image.FileSize,
                Id = image.Id,
                ImagePath = image.ImagePath,
                IsDefault = image.IsDefault,
                ProductId = image.ProductId,
                SortOrder = image.SortOrder
            };
            return viewModel;
        }

        public async Task<List<ProductImageViewModel>> GetListImages(int tableId)
        {
            return await _context.ProductImages.Where(x => x.ProductId == tableId)
                .Select(i => new ProductImageViewModel()
                {
                    Caption = i.Caption,
                    DateCreated = i.DateCreated,
                    FileSize = i.FileSize,
                    Id = i.Id,
                    ImagePath = i.ImagePath,
                    IsDefault = i.IsDefault,
                    ProductId = i.ProductId,
                    SortOrder = i.SortOrder
                }).ToListAsync();
        }

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);

            if (productImage == null)
                throw new HiverException($"Không thể tìm được ảnh {imageId}");

            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Update(productImage);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> RemoveImage(int imageId)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
                throw new HiverException($"Không tìm được ảnh {imageId}");
            _context.ProductImages.Remove(productImage);
            return await _context.SaveChangesAsync();
        }
    }
}