using System;
using CommandPattern.Conceptual;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();
            var receiver = new Receiver();
            
            invoker.SetOnStart(new SimpleCommand("Say Hi"));
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Send report"));
            invoker.DoSomethingImportant();
        }
    }
}