namespace VisitorPattern.Conceptual
{
    public class FooComponent : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFooComponent(this);
        }

        public string ExclusiveMethodOfFoo() => "Foo";
    }
}