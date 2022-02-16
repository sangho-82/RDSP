using System;

namespace VisitorPattern.Conceptual
{
    public class BarVisitor : IVisitor
    {
        public void VisitFooComponent(FooComponent foo) => Console.WriteLine($"{foo.ExclusiveMethodOfFoo()} BV");

        public void VisitBarComponent(BarComponent bar) => Console.WriteLine($"{bar.SpecialMethodOfBar()} BV");
    }
}