using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

#nullable disable

namespace Daskalo.Web.Filters
{
    /// <summary>
    /// A global filter that allow only active user access.
    /// </summary>
    public class OnlyActiveUserAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var userManager = context.HttpContext
                .RequestServices.GetService<UserManager<ApplicationUser>>();

            string userId = context.HttpContext.User.Id();
            var user = await userManager.FindByIdAsync(userId);

            if (user != null && user.IsDeleted)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    { "area", "Default"},
                    { "controller", "Home"},
                    { "action", "NotActive"}
                });
            }
            else
            {
                await next();
            }
        }
    }
}
