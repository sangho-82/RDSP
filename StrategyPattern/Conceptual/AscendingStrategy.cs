using System.Collections.Generic;

namespace StrategyPattern.Conceptual
{
    public class AscendingStrategy : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list?.Sort();

            return list;
        }
    }
}