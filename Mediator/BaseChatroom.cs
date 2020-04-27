namespace CMPS253.GoFPatterns.Behavioral.Mediator
{
    public abstract class BaseChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string sender, string receiver, string message);
    }
}