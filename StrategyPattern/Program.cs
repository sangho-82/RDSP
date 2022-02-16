using System;
using StrategyPattern.Conceptual;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            Console.WriteLine("Client: Strategy is set to normal sorting");
            context.SetStrategy(new AscendingStrategy());
            context.DoSomeBusinessLogic();
            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting");
            context.SetStrategy(new DescendingStrategy());
            context.DoSomeBusinessLogic();
        }
    }
}