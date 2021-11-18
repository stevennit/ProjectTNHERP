using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hiver.ApiIntegration;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Hiver.WebApp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

        public BaseController()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            var sessions = context.HttpContext.Session.GetString("Token");
            if (sessions == null)
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }
            string name = (string)context.RouteData.Values["Controller"];

            base.OnActionExecuting(context);
        }

    }
}