namespace FactoryMethodPattern.Conceptual
{
    public class CreatorBar : Creator
    {
        public override IProduct FactoryMethod() => new ProductBar();
    }
}