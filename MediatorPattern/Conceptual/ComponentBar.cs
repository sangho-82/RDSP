using System;

namespace MediatorPattern.Conceptual
{
    public class ComponentBar : BaseComponent
    {
        public void DoBaz()
        {
            Console.WriteLine("component bar does baz");
            Mediator?.Notify(this, "Baz");
        }

        public void DoQux()
        {
            Console.WriteLine("component bar does qux");
            Mediator?.Notify(this, "Qux");
        }
    }
}