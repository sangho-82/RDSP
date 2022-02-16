using System;

namespace VisitorPattern.Conceptual
{
    public class FooVisitor : IVisitor
    {
        public void VisitFooComponent(FooComponent foo) => Console.WriteLine($"{foo.ExclusiveMethodOfFoo()} FV");

        public void VisitBarComponent(BarComponent bar) => Console.WriteLine($"{bar.SpecialMethodOfBar()} FV");
    }
}