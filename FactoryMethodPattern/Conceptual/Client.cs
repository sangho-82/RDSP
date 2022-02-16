using System;

namespace FactoryMethodPattern.Conceptual
{
    public class Client
    {
        public static void ClientCode(Creator creator)
        {
            Console.WriteLine(
                $"Client: I am not aware of the creator's class, but it still works.\n{creator.SomeOperation()}");
        }
    }
}