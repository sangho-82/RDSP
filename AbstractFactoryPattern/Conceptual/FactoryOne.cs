namespace AbstractFactoryPattern.Conceptual
{
    public class FactoryOne : IAbstractFactory
    {
        public IAbstractProductFoo CreateProductFoo() => new ProductFooOne();

        public IAbstractProductBar CreateProductBar() => new ProductBarOne();
    }
}