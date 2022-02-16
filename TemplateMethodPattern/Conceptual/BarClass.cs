using System;

namespace TemplateMethodPattern.Conceptual
{
    public class BarClass : AbstractClass
    {
        protected override void RequiredOperation1() => Console.WriteLine("Bar: RO1");

        protected override void RequiredOperation2() => Console.WriteLine("Bar: RO2");

        protected override void Hook1() => Console.WriteLine("Bar: Hk1");
    }
}