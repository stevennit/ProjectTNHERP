using AutoMapper;
using Hiver.Data.Entities;
using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Catalog.ProductImages;
using Hiver.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductCategory, ProductCategoryVm>();

            CreateMap<ProductImage, ProductImageVm>();
            CreateMap<Product, ProductVm>();
        }
    }
}
