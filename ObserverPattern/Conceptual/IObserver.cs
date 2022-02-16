namespace ObserverPattern.Conceptual
{
    public interface IObserver
    {
        public void Update(ISubject subject);
    }
}