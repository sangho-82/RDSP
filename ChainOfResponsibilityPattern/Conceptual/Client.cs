using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern.Conceptual
{
    public class Client
    {
        public static void ClientCode(BaseHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}");
                var result = handler.Handle(food);
                Console.Write(result != null ? $"\t{result}" : $"\t{food} was left untouched.\n");
            }
        }
    }
}