using System;
using BridgePattern.Conceptual;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAbstraction abstraction = new BaseAbstraction(new ImplementationFoo());
            Client.ClientCode(abstraction);
            Console.WriteLine();

            abstraction = new DerivedAbstraction(new ImplementationBar());
            Client.ClientCode(abstraction);
        }
    }
}