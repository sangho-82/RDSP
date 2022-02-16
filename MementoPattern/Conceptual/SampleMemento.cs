using System;

namespace MementoPattern.Conceptual
{
    public class SampleMemento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _date;

        public SampleMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string GetName() => $"{_date} / ({_state[..9]})...";

        public string GetState() => _state;

        public DateTime GetDate() => _date;
    }
}