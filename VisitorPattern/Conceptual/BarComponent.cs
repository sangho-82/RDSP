namespace VisitorPattern.Conceptual
{
    public class BarComponent : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBarComponent(this);
        }

        public string SpecialMethodOfBar() => "BAR";
    }
}