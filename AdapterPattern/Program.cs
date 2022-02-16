using System;
using AdapterPattern.Conceptual;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var adaptee = new Adaptee();
            ITarget target = new AdapterObject(adaptee);
            
            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method");
            
            Console.WriteLine($"Result:\n{target.GetRequest()}");
        }
    }
}