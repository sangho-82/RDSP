namespace DecoratorPattern.Conceptual
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override string Operation() => _component != null ? _component.Operation() : string.Empty;
    }
}