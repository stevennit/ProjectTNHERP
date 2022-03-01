using Microsoft.AspNetCore.Mvc;

namespace Hiver.AdminApp.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
