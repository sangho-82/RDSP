namespace ChainOfResponsibilityPattern.Conceptual
{
    public class MonkeyHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            return request as string == "Banana" ? $"Monkey: I will eat the {request}\n" : base.Handle(request);
        }
    }
}