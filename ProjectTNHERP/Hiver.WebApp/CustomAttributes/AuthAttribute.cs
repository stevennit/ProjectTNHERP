using Hiver.ApiIntegration;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hiver.WebApp.Auth
{
    public class AuthAttribute : ActionFilterAttribute
    {
        private readonly IRoleApiClient _roleApiClient;
        public AuthAttribute(IRoleApiClient roleApiClient)
        {
            _roleApiClient = roleApiClient;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var userName = filterContext.HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.Name).Select(x => x.Value);

            var res = _roleApiClient.roleCheck(userName.ToString());
        }
    }
}
