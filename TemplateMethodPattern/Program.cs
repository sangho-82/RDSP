using System;
using TemplateMethodPattern.Conceptual;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses.");
            Client.ClientCode(new FooClass());
            Console.WriteLine();
            
            Console.WriteLine("Same client code can work with different subclasses.");
            Client.ClientCode(new BarClass());
        }
    }
}