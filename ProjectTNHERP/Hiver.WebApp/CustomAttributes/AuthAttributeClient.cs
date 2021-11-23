//using Hiver.ApiIntegration;
//using Hiver.ViewModels.Common;
//using Hiver.ViewModels.System.Roles;
//using Hiver.WebApp.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Hiver.WebApp.CustomAttributes
//{
//    public class AuthAttributeClient : ActionFilterAttribute
//    {
//        private readonly IRoleApiClient _roleApiClient;
//        public AuthAttributeClient(IRoleApiClient roleApiClient)
//        {
//            _roleApiClient = roleApiClient;
//        }

//        public override void OnActionExecuting(ActionExecutingContext context)
//        {
//            // Get name
//            string nameUser = context.HttpContext.User.Identity.Name;

//            // Get Name Controller and Name Action 
//            string nameController = (string)context.RouteData.Values["Controller"];
//            string nameAction = (string)context.RouteData.Values["Action"];

//            var request = new RoleCheckVm()
//            {
//                AppUser = nameUser,
//                Controller = nameController,
//                Action = nameAction
//            };

//            var res = _roleApiClient.roleCheck(request);

//            if (res.Result.IsSuccessed == true)
//            {
//                base.OnActionExecuting(context);
//            }
//            else
//            {
//                SetAlert("Bạn không có quyền truy cập", 2);
//                //context.Result = new UnprocessableEntityObjectResult(new ApiErrorResult<string>("Bạn không có quyền truy cập"));
//                return;
//            }

//        }

//        protected void SetAlert(string message, int type)
//        {
//            ViewNotification notification = new ViewNotification();
//            notification.message = message;

//            if (type == 1)
//            {
//                notification.AlertType = "alert-success";
//            }
//            else if (type == 2)
//            {
//                notification.AlertType = "alert-warning";
//            }
//            else if (type == 3)
//            {
//                notification.AlertType = "alert-danger";
//            }
//            else
//            {
//                notification.AlertType = "alert-info";
//            }
//        }

//    }
//}
