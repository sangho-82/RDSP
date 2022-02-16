using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern.Conceptual
{
    public class WordsCollection : IteratorAggregate
    {
        private readonly List<string> _collection = new();
        private bool _direction = false;

        public void ReverseDirection() => _direction = !_direction;

        public List<string> GetItems() => _collection;

        public void Add(string item)
        {
            _collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}