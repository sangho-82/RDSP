using System;

namespace StatePattern.Conceptual
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}");
            _state = state;
            _state.SetContext(this);
        }

        public void RequestFoo()
        {
            _state.HandleFoo();
        }

        public void RequestBar()
        {
            _state.HandleBar();
        }
    }
}