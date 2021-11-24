using Hiver.ApiIntegration;
using Hiver.Application.System.Roles;
using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hiver.WebApp.CustomAttributes
{
    public class AuthAttribute : ActionFilterAttribute
    {
        private readonly IRoleApiClient _roleApiClient;

        public AuthAttribute(IRoleApiClient roleApiClient)
        {
            _roleApiClient = roleApiClient;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Get name
            string nameUser = context.HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault();

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

            if (res.Result.ResultObj == true)
            {
                base.OnActionExecuting(context);
            }
            else
            {
                context.Result = new BadRequestObjectResult(new ApiErrorResult<string>("Bạn không có quyền truy cập"));
                return;
            }

        }
    }
}
