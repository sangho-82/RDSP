namespace IteratorPattern.Conceptual
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;
        private int _position = -1;
        private bool _reverse;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;
            if (reverse)
            {
                _position = collection.GetItems().Count;
            }
        }

        public override object Current() => _collection.GetItems()[_position];

        public override int Key() => _position;

        public override bool MoveNext()
        {
            var updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition < 0) return false;
            if (updatedPosition >= _collection.GetItems().Count) return false;

            _position = updatedPosition;
            
            return true;
        }

        public override void Reset() => _position = _reverse ? _collection.GetItems().Count - 1 : 0;
    }
}