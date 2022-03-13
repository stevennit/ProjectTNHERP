using AutoMapper;
using Hiver.Data.Entities;
using Hiver.ViewModels.Catalog.ProductCategories;
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
        }
    }
}
