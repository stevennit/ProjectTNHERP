using Hiver.ApiIntegration.Menu;
using Hiver.ViewModels.Common;
using Hiver.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.WebApp.Controllers.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuApiClient _menuApiClient;

        public MenuViewComponent(IMenuApiClient menuApiClient)
        {
            _menuApiClient = menuApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync(int parentId)
        {
            var res = GetMenuItem(parentId);
            return View("_MenuPartial",res);
        }
       

        private async Task<List<MenuViewModel>> GetChildrenMenu(int? parentId = null)
        {
            var res = await _menuApiClient.GetMenuParent(parentId);
            return res;
        }

        private async Task<List<MenuMain>> GetMenuItem(int Id)
        {
            var res = await _menuApiClient.GetMenus(Id);
            return res;
        }

    }
}