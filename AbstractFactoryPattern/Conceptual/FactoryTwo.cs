namespace AbstractFactoryPattern.Conceptual
{
    public class FactoryTwo : IAbstractFactory
    {
        public IAbstractProductFoo CreateProductFoo() => new ProductFooTwo();

        public IAbstractProductBar CreateProductBar() => new ProductBarTwo();
    }
}