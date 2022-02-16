using System;

namespace MediatorPattern.Conceptual
{
    public class ComponentFoo : BaseComponent
    {
        public void DoFoo()
        {
            Console.WriteLine("component foo does foo");
            Mediator?.Notify(this, "Foo");
        }

        public void DoBar()
        {
            Console.WriteLine("component foo does bar");
            Mediator?.Notify(this, "Bar");
        }
    }
}