using System;

namespace ObserverPattern.Conceptual
{
    public class ObserverFoo : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is not Subject realSubject) return;

            if (realSubject.State < 3)
            {
                Console.WriteLine("ObserverFoo: Reacted to the event.");
            }
        }
    }
}