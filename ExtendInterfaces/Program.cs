using System;
using ExtendInterfaces.Example;

namespace ExtendInterfaces
{

    class ExampleImpl : IExample
    {

    }

    class ExampleImpl2 : IExample
    {
        public string AddBehaviorToInterfaces(string param)
        {
            return "Overrided!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IExample example = new ExampleImpl();
            Console.WriteLine(example.AddBehaviorToInterfaces("Hello World!"));

            example = new ExampleImpl2(); // see new and override keywords behavior. Up-Casting
            Console.WriteLine(example.AddBehaviorToInterfaces("Hello World!"));

            var example2 = new ExampleImpl2(); 
            Console.WriteLine(example2.AddBehaviorToInterfaces("Hello World!"));
        }
    }
}
