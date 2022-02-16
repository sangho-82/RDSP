using System;

namespace TemplateMethodPattern.Conceptual
{
    public class FooClass : AbstractClass
    {
        protected override void RequiredOperation1() => Console.WriteLine("Foo: RO1");

        protected override void RequiredOperation2() => Console.WriteLine("Foo: RO2");

        protected override void Hook2() => Console.WriteLine("Foo: Hk2");
    }
}