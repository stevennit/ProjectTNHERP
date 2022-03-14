using Microsoft.AspNetCore.Mvc;

namespace Hiver.AdminApp.Controllers
{
    public class ImagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
