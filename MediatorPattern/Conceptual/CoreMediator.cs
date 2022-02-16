using System;

namespace MediatorPattern.Conceptual
{
    public class CoreMediator : IMediator
    {
        private ComponentFoo _foo;
        private ComponentBar _bar;

        public CoreMediator(ComponentFoo foo, ComponentBar bar)
        {
            _foo = foo;
            _foo.Mediator = this;
            _bar = bar;
            _bar.Mediator = this;
        }
        
        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "Foo":
                    Console.WriteLine("Mediator reacts on Foo and trigger following ops: ");
                    _bar.DoBaz();
                    break;
                case "Qux":
                    Console.WriteLine("Mediator reacts on Qux and trigger following ops: ");
                    _foo.DoBar();
                    _bar.DoBaz();
                    break;
            }
        }
    }
}