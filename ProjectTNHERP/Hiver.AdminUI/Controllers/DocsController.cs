using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminUI.Controllers
{
    public class DocsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Elfinder()
        {
            return View();
        }
        public IActionResult Tinymce()
        {
            return View();
        }
    }
}
