namespace AbstractFactoryPattern.Conceptual
{
    public interface IAbstractFactory
    {
        public IAbstractProductFoo CreateProductFoo();
        public IAbstractProductBar CreateProductBar();
    }
}