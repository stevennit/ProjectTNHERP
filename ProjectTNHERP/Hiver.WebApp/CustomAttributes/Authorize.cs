//using Hiver.ApiIntegration;
//using Hiver.ViewModels.System.Roles;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Security.Claims;
//using System.Threading.Tasks;

//namespace Hiver.WebApp.CustomAttributes
//{
//    public class AuthorizeAttribute : TypeFilterAttribute
//    {
//        public AuthorizeAttribute(params string[] claim) : base(typeof(AuthorizeFilter))
//        {
//            Arguments = new object[] { claim };
//        }
//    }


//    public class AuthorizeFilter : IAuthorizationFilter
//    {
//        readonly string[] _claim;
//        private readonly IRoleApiClient _roleApiClient = null;
//        public AuthorizeFilter(params string[] claim)
//        {
//            _claim = claim;
//        }

//        public void OnAuthorization(AuthorizationFilterContext context)
//        {
//            var IsAuthenticated = context.HttpContext.User.Identity.IsAuthenticated;



//            if (IsAuthenticated)
//            {

//                var claimsIndentity = context.HttpContext.User.Identity as ClaimsIdentity;

//                // Get the claims values

//                var nameuser = claimsIndentity.Claims.Where(c => c.Type == ClaimTypes.Name)
//                                   .Select(c => c.Value).FirstOrDefault();



//                // Get Name Controller and Name Action 
//                string nameController = (string)context.RouteData.Values["Controller"];
//                string nameAction = (string)context.RouteData.Values["Action"];

//                var roless = new RoleCheckVm()
//                {
//                    IdAppUser = nameuser,
//                    Controller = nameController,
//                    Action = nameAction
//                };

//                var dsd = new IRoleApiClient(roless);

//                ////var nameGroupRole = claimsPrincipal.

//                //bool flagClaim = false;

//                //foreach (var item in _claim)
//                //{
//                //    foreach (var itemrole in nameRole)
//                //    {
//                //        if (item == itemrole)
//                //            flagClaim = true;
//                //    }
//                //}
//                //if (!flagClaim)

//                //    if (context.HttpContext.Request.IsAjaxRequest())
//                //        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized; //Set HTTP 401
//                //    else
//                //        context.Result = new RedirectResult("~/Home/NoPermission");
//            }
//            return;
//        }
//    }
//}
