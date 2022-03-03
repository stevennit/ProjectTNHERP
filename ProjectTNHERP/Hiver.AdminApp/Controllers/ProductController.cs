using Microsoft.AspNetCore.Mvc;

namespace Hiver.AdminApp.Controllers
{
    public class ProductController : BaseController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
