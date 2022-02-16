namespace DecoratorPattern.Conceptual
{
    public class DecoratorFoo : Decorator
    {
        public DecoratorFoo(Component component) : base(component)
        {
        }

        public override string Operation() => $"decorator foo({base.Operation()})";
    }
}