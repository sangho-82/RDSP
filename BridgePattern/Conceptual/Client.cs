using System;

namespace BridgePattern.Conceptual
{
    public class Client
    {
        public static void ClientCode(BaseAbstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}