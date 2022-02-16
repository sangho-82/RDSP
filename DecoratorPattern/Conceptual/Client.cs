using System;

namespace DecoratorPattern.Conceptual
{
    public class Client
    {
        public static void ClientCode(Component component)
        {
            Console.WriteLine($"RESULT: {component.Operation()}");
        }
    }
}