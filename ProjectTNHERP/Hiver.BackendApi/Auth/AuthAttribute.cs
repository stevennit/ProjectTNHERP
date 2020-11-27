using Hiver.Application.System.Roles;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Auth
{
    public class AuthAttribute : ActionFilterAttribute
    {
        // IRoleService _roleService;
        //public AuthAttribute(IRoleService roleService)
        //{

        //}
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            LogDetails(filterContext);
        }

        private void LogDetails(ActionExecutingContext filterContext)
        {
            // Get name
            string nameUser = filterContext.HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault();

            // Get Name Controller and Name Action 
            string nameController = (string)filterContext.RouteData.Values["Controller"];
            string nameAction = (string)filterContext.RouteData.Values["Action"];

            

            RoleCheckVm request = new RoleCheckVm()
            { 
                AppUser = nameUser,
                Controller = nameController,
                Action = nameAction
            };
            
            RoleService roleService = new RoleService(request);

        }
    }
}
