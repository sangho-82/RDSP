namespace BridgePattern.Conceptual
{
    public class DerivedAbstraction : BaseAbstraction
    {
        public DerivedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation() =>
            $"DerivedAbstraction: Extended op. with: {base._implementation.OperationImplementation()}";
    }
}