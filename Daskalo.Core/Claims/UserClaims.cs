
namespace Daskalo.Core.Claims
{
    public static class UserClaims
    {
        public static KeyValuePair<string, string> ActivationStatusClaim =
            new KeyValuePair<string, string>("ActivationStatus", "Activated");

        public static string SchoolIdentifierClaim = "SchoolId";
    }
}
