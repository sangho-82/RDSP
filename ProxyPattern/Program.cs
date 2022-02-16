using System;
using ProxyPattern.Conceptual;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var realSubject = new RealSubject();
            
            Console.WriteLine("Client: Executing the client code with a real subject:");
            Client.ClientCode(realSubject);
            Console.WriteLine();
            
            Console.WriteLine("Client: Executing the same client code with a proxy:");
            var proxy = new Proxy(realSubject);
            Client.ClientCode(proxy);
        }
    }
}