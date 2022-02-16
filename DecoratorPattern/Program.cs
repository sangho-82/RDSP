using System;
using DecoratorPattern.Conceptual;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var simple = new ComponentFoo();
            Console.WriteLine("Main: I get a simple component: ");
            Client.ClientCode(simple);
            Console.WriteLine();

            var decoratorFoo = new DecoratorFoo(simple);
            var decoratorBar = new DecoratorBar(decoratorFoo);
            Console.WriteLine("Main: Now I have got a decorated component: ");
            Client.ClientCode(decoratorBar);
        }
    }
}