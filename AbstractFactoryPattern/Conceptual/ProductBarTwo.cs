namespace AbstractFactoryPattern.Conceptual
{
    public class ProductBarTwo : IAbstractProductBar
    {
        public string UsefulFunctionBar() => "[the result of the product bar_two]";

        public string AnotherUsefulFunctionBar(IAbstractProductFoo productFoo) =>
            $"[result of the bar_two collab. with the {productFoo.UsefulFunctionFoo()}]";
    }
}