using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration.ProductCategory
{
    public interface IProductCategoryApiClient
    {
        Task<PagedResult<ProductCategoryVm>> GetAllPaging(GetAllProductCategoryPagingRequest request);
        Task<List<ProductCategoryVm>> GetAll();

        Task<ApiResult<bool>> RoleCreate(ProductCategoryCreateRequest request);

        Task<ApiResult<bool>> RoleUpdate(int id, ProductCategoryUpdateRequest request);

        Task<ProductCategoryVm> GetById(int id);

        Task<ApiResult<bool>> Delete(int id);
    }
}
