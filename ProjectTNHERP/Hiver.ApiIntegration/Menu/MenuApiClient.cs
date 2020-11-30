using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration.Menu
{
    public class MenuApiClient : BaseApiClient, IMenuApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public MenuApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        
        public async Task<List<MenuMain>> GetMenus(int Id)
        {
            var data = await GetListAsync<MenuMain>($"/api/menus/Getmenu/{Id}");

            return data;
        }
        public async Task<List<MenuViewModel>> GetMenuParent(int? parentId)
        {
            var data = await GetListAsync<MenuViewModel>($"/api/menus/Getmenuparent/{parentId}");

            return data;
        }


    }
}
