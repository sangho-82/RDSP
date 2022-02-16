namespace MediatorPattern.Conceptual
{
    public class BaseComponent
    {
        public IMediator Mediator { protected get; set; } = null;
    }
}