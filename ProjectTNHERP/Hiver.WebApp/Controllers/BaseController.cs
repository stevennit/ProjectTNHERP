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
        private readonly IRoleApiClient _roleApiClient;
        public BaseController(IRoleApiClient roleApiClient)
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            var sessions = context.HttpContext.Session.GetString("Token");

            if (sessions == null)
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }


            // Get name
            string nameUser = context.HttpContext.User.Identity.Name;

            // Get Name Controller and Name Action 
            string nameController = (string)context.RouteData.Values["Controller"];
            string nameAction = (string)context.RouteData.Values["Action"];

            var request = new RoleCheckVm()
            {
                AppUser = nameUser,
                Controller = nameController,
                Action = nameAction
            };

            var res = _roleApiClient.roleCheck(request);

            base.OnActionExecuting(context);
        }

        protected void SetAlert(string massage, string type)
        {
            TempData["AlertMessage"] = massage;

            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == "warring")
            {
                TempData["AlertType"] = "alert-success";
            }
        }

    }
}