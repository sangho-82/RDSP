using System;

namespace MementoPattern.Conceptual
{
    public interface IMemento
    {
        public string GetName();
        public string GetState();
        public DateTime GetDate();
    }
}