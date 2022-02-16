using System;
using StatePattern.Conceptual;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new StateFoo());
            context.RequestFoo();
            
            context.TransitionTo(new StateBar());
            context.RequestBar();
        }
    }
}