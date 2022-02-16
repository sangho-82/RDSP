namespace BridgePattern.Conceptual
{
    public class BaseAbstraction
    {
        protected IImplementation _implementation;

        public BaseAbstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation() =>
            $"BaseAbstraction: Base op. with: {_implementation.OperationImplementation()}";
    }
}