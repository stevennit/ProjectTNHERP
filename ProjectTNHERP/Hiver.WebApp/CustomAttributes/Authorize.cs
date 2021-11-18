﻿//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Newtonsoft.Json.Linq;
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
//                var nameRole = claimsIndentity.Claims.Where(c => c.Type == ClaimTypes.Role)
//                                   .Select(c => c.Value).ToList();

//                //var nameGroupRole = claimsPrincipal.

//                bool flagClaim = false;

//                foreach (var item in _claim)
//                {
//                    foreach (var itemrole in nameRole)
//                    {
//                        if (item == itemrole)
//                            flagClaim = true;
//                    }
//                }
//                if (!flagClaim)

//                    if (context.HttpContext.Request.IsAjaxRequest())
//                        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized; //Set HTTP 401
//                    else
//                        context.Result = new RedirectResult("~/Shared/Error.cshtml");
//            }
//            return;
//        }
//    }
//}
