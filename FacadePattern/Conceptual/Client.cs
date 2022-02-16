using System;

namespace FacadePattern.Conceptual
{
    public class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}