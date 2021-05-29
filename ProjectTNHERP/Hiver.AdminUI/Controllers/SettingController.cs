using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SettingController(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            ViewBag.NumberNav = _httpContextAccessor.HttpContext.Request.Cookies["IdMenu"];
            return View();
        }
    }
}
