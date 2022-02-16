using System;
using System.Collections.Generic;
using System.Threading;

namespace ObserverPattern.Conceptual
{
    public class Subject : ISubject
    {
        public int State { get; set; } = 0;
        private readonly List<IObserver> _observers = new();
        
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached on observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached on observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I am doing something important.");
            State = new Random().Next(0, 16);
            
            Thread.Sleep(15);
            
            Console.WriteLine($"Subject: My state hsa just changed to: {State}");
            Notify();
        }
    }
}