using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hiver.AdminApp.CustomAttributes
{
    public class AuthorizeAttribute
    {
        public AuthorizeAttribute(AuthorizationFilterContext context)
        {

            if (context.HttpContext.Request.IsAjaxRequest())
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized; //Set HTTP 401
            else
                context.Result = new RedirectResult("~/Home/NoPermission");
            return;
        }
    }

}
