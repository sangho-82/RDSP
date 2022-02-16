using System;
using IteratorPattern.Conceptual;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordsCollection { "First", "Second", "Third" };
            
            Console.WriteLine("Straight traversal: ");
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            
            collection.ReverseDirection();
            Console.WriteLine("Reverse traversal: ");
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}