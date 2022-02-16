namespace VisitorPattern.Conceptual
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}