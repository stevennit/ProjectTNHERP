//using Hiver.ApiIntegration;
//using Hiver.ViewModels.System.Roles;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Security.Principal;
//using System.Threading.Tasks;

//namespace Hiver.WebApp.CustomAttributes
//{
//    public static class PermissionExtension
//    {
//        public static IRoleApiClient _roleApiClient;

//        public static bool HavePermission(this Controller c, string claimValue)
//        {
//            var user = c.HttpContext.User as ClaimsPrincipal;

//            bool havePer = user.HasClaim(claimValue, claimValue);
//            return havePer;
//        }

//        public static bool HavePermission(this IIdentity claims, string ControllerName, string ActionName)
//        {
//            var userClaims = claims as ClaimsIdentity;

//            var request = new RoleCheckVm()
//            {
//                AppUser = userClaims.Name,
//                Controller = ControllerName,
//                Action = ActionName
//            };

//            //var res = _roleApiClient.roleCheck(request);

//             return false;

//        }
//    }
//}
