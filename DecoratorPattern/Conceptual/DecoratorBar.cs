namespace DecoratorPattern.Conceptual
{
    public class DecoratorBar : Decorator
    {
        public DecoratorBar(Component component) : base(component)
        {
        }

        public override string Operation() => $"decorator bar({base.Operation()})";
    }
}