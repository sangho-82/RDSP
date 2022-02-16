namespace ChainOfResponsibilityPattern.Conceptual
{
    public class DogHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            return request.ToString() == "MeatBall" ? $"Dog: I will eat {request}\n" : base.Handle(request);
        }
    }
}