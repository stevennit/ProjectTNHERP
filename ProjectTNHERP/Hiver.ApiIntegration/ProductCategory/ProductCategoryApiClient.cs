using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration.ProductCategory
{
    public class ProductCategoryApiClient : BaseApiClient, IProductCategoryApiClient
    {
        public ProductCategoryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public Task<ApiResult<bool>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductCategoryVm>> GetAll()
        {
            return await GetListAsync<ProductCategoryVm>("/api/productCategories");
        }

        public Task<PagedResult<ProductCategoryVm>> GetAllPaging(GetAllProductCategoryPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductCategoryVm> GetById(int id)
        {
            return await GetAsync<ProductCategoryVm>($"/api/productCategories/{id}");
        }

        public Task<ApiResult<bool>> RoleCreate(ProductCategoryCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> RoleUpdate(int id, ProductCategoryUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
