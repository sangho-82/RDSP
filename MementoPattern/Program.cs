using System;
using MementoPattern.Conceptual;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var origin = new Origin("Super-duper-super-puper-super.");
            var care = new Caretaker(origin);
            
            care.BackUp();
            origin.DoSomething();
            
            care.BackUp();
            origin.DoSomething();
            
            care.BackUp();
            origin.DoSomething();
            Console.WriteLine();
            
            care.ShowHistory();
            Console.WriteLine("\nClient: Now, let's rollback!");
            care.Undo();
            
            Console.WriteLine("\n\nOnce more!\n");
            care.Undo();
            Console.WriteLine();
        }
    }
}