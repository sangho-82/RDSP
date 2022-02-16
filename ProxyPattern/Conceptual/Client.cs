namespace ProxyPattern.Conceptual
{
    public class Client
    {
        public static void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}