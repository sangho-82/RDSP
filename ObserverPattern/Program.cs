using System;
using ObserverPattern.Conceptual;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerFoo1 = new ObserverFoo();
            subject.Attach(observerFoo1);

            var observerBar1 = new ObserverBar();
            subject.Attach(observerBar1);
            
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            
            subject.Detach(observerBar1);
            
            subject.SomeBusinessLogic();
        }
    }
}