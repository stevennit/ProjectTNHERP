//using Hiver.ApiIntegration;
//using Hiver.ViewModels.System.Roles;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Hiver.WebApp.CustomAttributes
//{
//    public class AuthorizeActionFilter : ActionFilterAttribute
//    {
//        public override void OnResultExecuting(ResultExecutingContext context)
//        {
//            // Get Name Controller and Name Action 
//            string nameController = (string)context.RouteData.Values["Controller"];
//            string nameAction = (string)context.RouteData.Values["Action"];

//            var res = roleCheck(nameController, nameAction,"itds");
//        }

//        private bool roleCheck(string Controller,string Action, string user)
//        {
//            RoleApiClient roleApiClient = new RoleApiClient();
            

//            var roless = new RoleCheckVm()
//            {
//                AppUser = user,
//                Controller = Controller,
//                Action = Action
//            };

//            var result = roleApiClient.roleCheck(roless);
            
//            return true;
//        }
//    }
//}
