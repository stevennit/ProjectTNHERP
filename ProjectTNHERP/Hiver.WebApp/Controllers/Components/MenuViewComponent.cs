using Hiver.ApiIntegration.Menu;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IViewComponentResult> InvokeAsync(int? ParentID)
        {
            var res = await _menuApiClient.GetMenus(ParentID);
            return View(res);
        }
    }
}