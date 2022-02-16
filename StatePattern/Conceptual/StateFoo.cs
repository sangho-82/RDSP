using System;

namespace StatePattern.Conceptual
{
    public class StateFoo : State
    {
        public override void HandleFoo()
        {
            Console.WriteLine("StateFoo: handle foo request");
        }

        public override void HandleBar()
        {
            Console.WriteLine("StateFoo: handle bar request");
        }
    }
}