namespace MediatorPattern.Conceptual
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}