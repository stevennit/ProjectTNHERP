using BootstrapBreadcrumbs.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.AdminUI.Controllers
{
    [Breadcrumbs(Title = "Category", Action = "Index")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
