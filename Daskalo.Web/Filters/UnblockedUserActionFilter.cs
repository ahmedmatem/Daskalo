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
    public class UnblockedUserActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var userManager = context.HttpContext
                .RequestServices
                .GetService<UserManager<ApplicationUser>>();

            string userId = context.HttpContext.User.Id();
            var user = await userManager.FindByIdAsync(userId);

            if (user != null && user.IsDeleted)
            {
                var signInManager = context.HttpContext
                    .RequestServices
                    .GetService<SignInManager<ApplicationUser>>();
                await signInManager.SignOutAsync();

                context.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/BlockedUser.cshtml",
                };
            }
            else
            {
                await next();
            }
        }
    }
}
