using AvoidTightCoupling.AutenticationAspect;
using AvoidTightCoupling.Domain;

namespace AvoidTightCoupling.ExtendedBehavior
{
    public static class UserExtensions
    {
        public static bool IsAuthenticated(this User user)
        {
            var claim = new UserClaim()
            {
                HasKeySession = user.Name.StartsWith("A")
            };

            return ExampleAuthentication.IsAuthenticated(claim);
        }
    }
}