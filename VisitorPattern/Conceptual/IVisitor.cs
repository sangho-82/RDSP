namespace VisitorPattern.Conceptual
{
    public interface IVisitor
    {
        void VisitFooComponent(FooComponent foo);
        void VisitBarComponent(BarComponent bar);
    }
}