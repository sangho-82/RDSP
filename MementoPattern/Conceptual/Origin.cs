using System;
using System.Threading;

namespace MementoPattern.Conceptual
{
    public class Origin
    {
        private string _state;

        public Origin(string state)
        {
            _state = state;
            Console.WriteLine($"Origin: My initial state is: {state}");
        }

        public void DoSomething()
        {
            Console.WriteLine("Origin: I am doing something important.");
            _state = _GenerateRandomString(30);
            Console.WriteLine($"Origin: and my state has changed to: {_state}");
        }

        private string _GenerateRandomString(int length = 10)
        {
            const string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];
                Thread.Sleep(12);
                length--;
            }

            return result;
        }

        public IMemento Save() => new SampleMemento(_state);

        public void Restore(IMemento memento)
        {
            if (memento is not SampleMemento)
                throw new Exception($"Unknown memento class {memento}");

            _state = memento.GetState();
            Console.Write($"Origin: My state has changed to: {_state}");
        }
    }
}