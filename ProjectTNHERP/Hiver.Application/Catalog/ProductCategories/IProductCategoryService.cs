﻿using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Catalog.ProductCategories
{
    public interface IProductCategoryService
    {


        Task<PagedResult<ProductCategoryVm>> GetAllPaging(GetAllProductCategoryPagingRequest request);
        Task<List<ProductCategoryVm>> GetAll();
        Task<ProductCategoryVm> GetById(Guid Id);
        Task<Guid> Create(ProductCategoryCreateRequest request);
        Task<Guid> Update(ProductCategoryUpdateRequest request);
        Task<Guid> Delete(Guid productId);
    }
}
