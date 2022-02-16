using System;

namespace StatePattern.Conceptual
{
    public class StateBar : State
    {
        public override void HandleFoo()
        {
            Console.WriteLine("StateBar: handle foo request");
        }

        public override void HandleBar()
        {
            Console.WriteLine("StateBar: handle bar request");
        }
    }
}