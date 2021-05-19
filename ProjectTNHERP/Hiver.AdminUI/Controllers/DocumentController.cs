using BootstrapBreadcrumbs.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminUI.Controllers
{
    [Breadcrumbs(Title = "Document", Action = "Index")]
    public class DocumentController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }


        [Breadcrumbs(Title = "Elfinder")]
        public IActionResult Elfinder()
        {
            return View();
        }


        [Breadcrumbs(Title = "Tinymce")]
        public IActionResult Tinymce()
        {
            return View();
        }
    }
}
