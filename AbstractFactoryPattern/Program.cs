using System;
using AbstractFactoryPattern.Conceptual;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main: Testing with FactoryOne");
            Client.ClientMethod(new FactoryOne());
            Console.WriteLine();
            
            Console.WriteLine("Main: Testing with FactoryTwo");
            Client.ClientMethod(new FactoryTwo());
        }
    }
}