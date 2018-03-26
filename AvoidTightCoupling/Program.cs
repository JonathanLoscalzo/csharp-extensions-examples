using System;
using AvoidTightCoupling.Domain;
using AvoidTightCoupling.ExtendedBehavior;

namespace AvoidTightCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            var ale = new User()
            {
                Name = "Alejandro"
            };

            var smith = new User()
            {
                Name = "Smith"
            };

            var msg = "{0} is Authenticated? : {1}";

            Console.WriteLine(string.Format(msg, ale.Name, ale.IsAuthenticated()));
            Console.WriteLine(string.Format(msg, smith.Name, smith.IsAuthenticated()));
        }
    }
}
