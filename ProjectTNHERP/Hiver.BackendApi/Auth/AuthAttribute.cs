using Hiver.Application.System.Roles;
using Hiver.Application.System.Users;
using Hiver.Data.Entities;
using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Identity;
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
        private readonly IRoleService _roleService;
        private readonly IUserService _userService;
        public AuthAttribute(IRoleService roleService, IUserService userService)
        {
            _roleService = roleService;
            _userService = userService;
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
                ControllerName = nameController,
                ActionName = nameAction
            };

            var res = _roleService.roleCheck(nameUser,request);


            if (res.Result.IsSuccessed == true || nameUser == "admin")
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
