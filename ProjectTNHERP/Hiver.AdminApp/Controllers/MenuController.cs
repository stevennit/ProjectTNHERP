using Hiver.ApiIntegration.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hiver.AdminApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuApiClient _menuApiClient;
        public MenuController(IMenuApiClient menuApiClient)
        {
            _menuApiClient = menuApiClient;
        }

    }
}
