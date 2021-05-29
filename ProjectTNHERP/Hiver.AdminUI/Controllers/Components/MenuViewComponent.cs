using Hiver.ApiIntegration.Menu;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminUI.Controllers.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuApiClient _menuApiClient;

        public const string SessionKeyName = "_Name";

        public MenuViewComponent(IMenuApiClient menuApiClient)
        {
            _menuApiClient = menuApiClient;
        }

        public Task<IViewComponentResult> InvokeAsync(int? parentId, int? menuOrder)
        {
            var children = GetMenu(parentId, menuOrder);

            // Requires: using Microsoft.AspNetCore.Http;
            //if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
            //{
            //    HttpContext.Session.SetString(SessionKeyName, "The Doctor");
            //}

            //var name = HttpContext.Session.GetString(SessionKeyName);


            return Task.FromResult((IViewComponentResult)View("_MenuPartial", children));

        }

        public IList<MenuViewModel> GetMenu(int? parentId,int? menuOrder)
        {
            var children = _menuApiClient.GetChildrenMenu(parentId, menuOrder);

            if (!children.Result.Any())
            {
                return new List<MenuViewModel>();
            }

            var vmList = new List<MenuViewModel>();

            foreach (var item in children.Result)
            {
                var menu = _menuApiClient.GetMenuItem(item.MenuId);
                var vm = new MenuViewModel();

                vm.MenuId = menu.Result.MenuId;
                vm.MenuName = menu.Result.MenuName;
                vm.MenuOrder = menu.Result.MenuOrder;
                vm.Description = menu.Result.Description;
                vm.IconClass = menu.Result.IconClass;
                vm.IconNumber = menu.Result.IconNumber == null ? "" : menu.Result.IconNumber;
                vm.Url = menu.Result.Url;
                vm.IsVisible = menu.Result.IsVisible;

                vm.Children = GetMenu(menu.Result.MenuId,menuOrder);
               
                vmList.Add(vm);
            }
            return vmList;
        }
    }
}
