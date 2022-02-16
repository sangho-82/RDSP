using System.Collections;

namespace IteratorPattern.Conceptual
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}