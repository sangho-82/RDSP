using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyweightPattern.Conceptual
{
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> _flyweights = new();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var arg in args)
            {
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(arg), GetKey(arg)));
            }
        }

        public string GetKey(Car key)
        {
            List<string> elements = new()
            {
                key.Model,
                key.Color,
                key.Company
            };

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();
            
            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            var key = GetKey(sharedState);

            if (_flyweights.All(t => t.Item2 != key))
            {
                Console.WriteLine("FlyweightFactory: Cannot find a flyweight, create new one!");
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }

            return _flyweights.FirstOrDefault(t => t.Item2 == key)?.Item1;
        }

        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}