using System;
using FactoryMethodPattern.Conceptual;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main: Launched with the creator_foo");
            Client.ClientCode(new CreatorFoo());
            Console.WriteLine();
            
            Console.WriteLine("Main: Launched with the creator_bar");
            Client.ClientCode(new CreatorBar());
        }
    }
}