using System;

namespace AbstractFactoryPattern.Conceptual
{
    public class Client
    {
        public static void ClientMethod(IAbstractFactory factory)
        {
            var productFoo = factory.CreateProductFoo();
            var productBar = factory.CreateProductBar();
            
            Console.WriteLine(productBar.UsefulFunctionBar());
            Console.WriteLine(productBar.AnotherUsefulFunctionBar(productFoo));
        }
    }
}