using System;
using MediatorPattern.Conceptual;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var componentFoo = new ComponentFoo();
            var componentBar = new ComponentBar();
            var mediator = new CoreMediator(componentFoo, componentBar);
            
            Console.WriteLine("Client triggers op Foo");
            componentFoo.DoFoo();
            Console.WriteLine();
            
            Console.WriteLine("Client triggers op Qux");
            componentBar.DoQux();
        }
    }
}