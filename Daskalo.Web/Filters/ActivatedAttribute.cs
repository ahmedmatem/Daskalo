using Daskalo.Core.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using static Daskalo.Core.Claims.UserClaims;

namespace Daskalo.Web.Filters
{
    public class ActivatedAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var activated = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == UserClaims.ActivationStatusClaim.Key);
            if (activated == null)
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary()
                    {
                        { "Area", "Default"},
                        { "controller", "Home"},
                        { "action", "NotActivated"}
                    });
            }

            await next();
        }
    }
}
