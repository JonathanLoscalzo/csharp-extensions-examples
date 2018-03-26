namespace AvoidTightCoupling.AutenticationAspect
{
    public static class ExampleAuthentication
    {
        public static bool IsAuthenticated(UserClaim user) => user.HasKeySession;
    }
}