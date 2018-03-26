namespace ExtendInterfaces.Example
{
    public static class IExampleExtensions
    {
        public static string AddBehaviorToInterfaces(this IExample self, string parameter)
        {
            return parameter + "Interface Behavior!";
        }

    }
}