using System;

namespace CommandPattern.Conceptual
{
    public class Receiver
    {
        public void DoSomething(string str)
        {
            Console.WriteLine($"Receiver: Working on ({str}).");
        }

        public void DoSomethingElse(string str)
        {
            Console.WriteLine($"Receiver: Also working on ({str}).");
        }
    }
}