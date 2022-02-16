using System;
using BuilderPattern.Conceptual;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new SampleBuilder();
            director.Builder = builder;
            
            Console.WriteLine("Standard Basic: ");
            director.BuildMinimalSpec();
            Console.WriteLine(builder.GetProduct().ListParts());
            
            Console.WriteLine("Standard Full: ");
            director.BuildMaximalSpec();
            Console.WriteLine(builder.GetProduct().ListParts());
            
            Console.WriteLine("Custom: ");
            builder.BuildPartFoo();
            builder.BuildPartBaz();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}