using System;
using System.Threading;
using SingletonThreadSafePattern.Conceptual;

namespace SingletonThreadSafePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var processFoo = new Thread(() =>
            {
                var singleton = ThreadSafeSingleton.GetInstance("Foo");
                Console.WriteLine(singleton.Value);
            });
            var processBar = new Thread(() =>
            {
                var singleton = ThreadSafeSingleton.GetInstance("Bar");
                Console.WriteLine(singleton.Value);
            });
            
            processFoo.Start();
            processBar.Start();

            processFoo.Join();
            processBar.Join();
        }
    }
}