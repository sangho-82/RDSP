using System;

namespace CommandPattern.Conceptual
{
    public class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;
        private readonly string _stringFoo;
        private readonly string _stringBar;

        public ComplexCommand(Receiver receiver, string foo, string bar)
        {
            _receiver = receiver;
            _stringFoo = foo;
            _stringBar = bar;
        }
        
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            _receiver.DoSomething(_stringFoo);
            _receiver.DoSomething(_stringBar);
        }
    }
}