using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProjectManagement.Entities;
using ProjectManagement.ExtentionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ActionFilters
{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetObject<User>("loggedUser") == null)
                context.Result = new RedirectResult("/Home/Login");
        }
    }
}
