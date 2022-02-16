using System;

namespace ProxyPattern.Conceptual
{
    public class RealSubject : ISubject
    {
        public void Request() => Console.WriteLine("RealSubject: Handling Request.");
    }
}