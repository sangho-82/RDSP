namespace AbstractFactoryPattern.Conceptual
{
    public class ProductBarOne : IAbstractProductBar
    {
        public string UsefulFunctionBar() => "[the result of the product bar_one]";

        public string AnotherUsefulFunctionBar(IAbstractProductFoo productFoo) =>
            $"[result of the bar_one collab. with the {productFoo.UsefulFunctionFoo()}]";
    }
}