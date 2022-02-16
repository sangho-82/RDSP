using System;
using FacadePattern.Conceptual;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var systemFoo = new SubsystemFoo();
            var systemBar = new SubsystemBar();
            var facade = new Facade(systemFoo, systemBar);
            
            Client.ClientCode(facade);
        }
    }
}