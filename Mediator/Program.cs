namespace CMPS253.GoFPatterns.Behavioral.Mediator
{
    public class MainApp
    {
        static void Main()
        {
            Chatroom chatroom = new Chatroom();

            Participant Joe = new Participant("Joe");
            Participant Sally = new Participant("Sally");
            Participant Ted = new Participant("Ted");

            chatroom.Register(Joe);
            chatroom.Register(Sally);
            chatroom.Register(Ted);

            // Chatting participants
            Sally.Send("Ted", "Good morning");
            Ted.Send("Joe", "How are you?");
            Joe.Send("Sally", "I am done");
        }
    }
}