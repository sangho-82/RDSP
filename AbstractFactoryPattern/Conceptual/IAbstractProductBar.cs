namespace AbstractFactoryPattern.Conceptual
{
    public interface IAbstractProductBar
    {
        public string UsefulFunctionBar();
        public string AnotherUsefulFunctionBar(IAbstractProductFoo productFoo);
    }
}