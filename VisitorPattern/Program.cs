using System;
using System.Collections.Generic;
using VisitorPattern.Conceptual;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new List<IComponent>
            {
                new FooComponent(),
                new BarComponent(),
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface: ");
            var visitor1 = new FooVisitor();
            Client.ClientCode(components, visitor1);
            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors");
            var visitor2 = new BarVisitor();
            Client.ClientCode(components, visitor2);
        }
    }
}