using Hiver.Utilities.Constants;
using Hiver.ViewModels.Catalog.Products;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration.Product
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> CreateProduct(ProductVm request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            //if (request.ThumbnailImage != null)
            //{
            //    byte[] data;
            //    using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
            //    {
            //        data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
            //    }
            //    ByteArrayContent bytes = new ByteArrayContent(data);
            //    requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            //}

            requestContent.Add(new StringContent(request.Name.ToString()), "name");
            requestContent.Add(new StringContent(request.Symbol.ToString()), "symbol");
            requestContent.Add(new StringContent(request.Height.ToString()), "height");
            requestContent.Add(new StringContent(request.Width.ToString()), "width");

            if(request.Description != null)
            {
                requestContent.Add(new StringContent(request.Description.ToString()), "description");
            }    
            
            if(request.Detail != null)
            {
                requestContent.Add(new StringContent(request.Detail.ToString()), "detail");
            }
           
            requestContent.Add(new StringContent(request.CreateDate.ToString()), "createDate");
            requestContent.Add(new StringContent(request.CreateBy.ToString()), "createBy");

            var response = await client.PostAsync($"/api/products/", requestContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateProduct(ProductVm request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            //if (request.ThumbnailImage != null)
            //{
            //    byte[] data;
            //    using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
            //    {
            //        data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
            //    }
            //    ByteArrayContent bytes = new ByteArrayContent(data);
            //    requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            //}

            requestContent.Add(new StringContent(request.Name.ToString()), "name");
            requestContent.Add(new StringContent(request.Symbol.ToString()), "symbol");
            requestContent.Add(new StringContent(request.Height.ToString()), "height");
            requestContent.Add(new StringContent(request.Width.ToString()), "width");

            if (request.Description != null)
            {
                requestContent.Add(new StringContent(request.Description.ToString()), "description");
            }

            if (request.Detail != null)
            {
                requestContent.Add(new StringContent(request.Detail.ToString()), "detail");
            }

            requestContent.Add(new StringContent(request.ModifyDate.ToString()), "modifydate");
            requestContent.Add(new StringContent(request.ModifyBy.ToString()), "modifyby");

            var response = await client.PutAsync($"/api/products/" + request.Id,requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductVm>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&categoryId={request.CategoryId}");

            return data;
        }

        public async Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"/api/products/{id}/productassign", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<ProductVm> GetById(Guid id)
        {
            var data = await GetAsync<ProductVm>($"/api/products/{id}");

            return data;
        }

        public async Task<List<ProductVm>> GetFeaturedProducts(int take)
        {
            var data = await GetListAsync<ProductVm>($"/api/products/featured/{take}");
            return data;
        }

        public async Task<List<ProductVm>> GetLatestProducts(int take)
        {
            var data = await GetListAsync<ProductVm>($"/api/products/latest/{take}");
            return data;
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            return await Delete($"/api/products/" + id);
        }
    }
}
