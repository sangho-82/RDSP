using System;
using Newtonsoft.Json;

namespace FlyweightPattern.Conceptual
{
    public class Flyweight
    {
        private readonly Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            var s = JsonConvert.SerializeObject(_sharedState);
            var u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}