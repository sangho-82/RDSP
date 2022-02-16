using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern.Conceptual
{
    public class Caretaker
    {
        private List<IMemento> _mementoes = new();
        private Origin _origin;

        public Caretaker(Origin origin)
        {
            _origin = origin;
        }

        public void BackUp()
        {
            Console.WriteLine("\nCaretaker: Saving Origin's state..");
            _mementoes.Add(_origin.Save());
        }

        public void Undo()
        {
            if (_mementoes.Count == 0) return;

            var memento = _mementoes.Last();
            _mementoes.Remove(memento);
            Console.WriteLine($"Caretaker: Restoring state to: {memento.GetName()}");

            try
            {
                _origin.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");
            foreach (var memento in _mementoes)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}