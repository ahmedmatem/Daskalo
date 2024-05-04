
namespace Daskalo.Core.Claims
{
    public static class UserClaims
    {
        public static KeyValuePair<string, string> AuthClaim =
            new KeyValuePair<string, string>("Authorization", "Activated");
    }
}
