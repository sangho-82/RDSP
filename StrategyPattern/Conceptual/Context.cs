using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Conceptual
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {
            
        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy) => _strategy = strategy;

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it)");
            var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });
            var sb = new StringBuilder();
            foreach (var item in (List<string>)result)
            {
                sb.Append($"{item}, ");
            }

            Console.WriteLine(sb);
        }
    }
}