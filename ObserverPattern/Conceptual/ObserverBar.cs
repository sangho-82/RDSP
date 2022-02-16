using System;

namespace ObserverPattern.Conceptual
{
    public class ObserverBar : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is not Subject realSubject) return;

            if (realSubject.State is 0 or >= 2)
            {
                Console.WriteLine("ObserverBar: Reacted to the event");
            }
        }
    }
}