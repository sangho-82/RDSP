using System;

namespace CompositePattern.Conceptual
{
    public class Client
    {
        public static void ClientCodeFoo(Component component)
        {
            Console.WriteLine($"RESULT: {component.Operation()}");
        }

        public static void ClientCodeBar(Component with, Component and)
        {
            if (with.IsComposite())
            {
                with.Add(and);
            }
            ClientCodeFoo(with);
        }
    }
}