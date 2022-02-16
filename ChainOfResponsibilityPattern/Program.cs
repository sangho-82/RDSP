using System;
using ChainOfResponsibilityPattern.Conceptual;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();
            
            Console.WriteLine("Sub-chain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }
    }
}