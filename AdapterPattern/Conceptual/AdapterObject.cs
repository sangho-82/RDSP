namespace AdapterPattern.Conceptual
{
    public class AdapterObject : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterObject(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest() => $"This is [{_adaptee.GetSpecialRequest()}]";
    }
}