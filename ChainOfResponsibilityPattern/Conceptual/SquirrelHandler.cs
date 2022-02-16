namespace ChainOfResponsibilityPattern.Conceptual
{
    public class SquirrelHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            return request.ToString() == "Nut" ? $"Squirrel: I will eat the {request}\n" : base.Handle(request);
        }
    }
}