namespace FactoryMethodPattern.Conceptual
{
    public class CreatorFoo : Creator
    {
        public override IProduct FactoryMethod() => new ProductFoo();
    }
}