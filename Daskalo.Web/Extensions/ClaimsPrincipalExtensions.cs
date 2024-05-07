using System.Security.Claims;
using static Daskalo.Core.Constants.UserClaimsConstants;

namespace Daskalo.Web.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string? Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static string SchoolId(this ClaimsPrincipal user)
        {
            return user
                .Claims
                .FirstOrDefault(c => c.Type == SchoolIdentifierClaim)?
                .Value 
                ?? string.Empty;
        }
    }
}
