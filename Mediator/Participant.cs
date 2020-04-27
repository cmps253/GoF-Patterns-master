using System;

namespace CMPS253.GoFPatterns.Behavioral.Mediator
{
    public class Participant
    {
        public BaseChatroom Chatroom { get; internal set; }
        public string Name { get; private set; }

        // Constructor
        public Participant(string name)
        {
            this.Name = name;
        }

        // Sends message to given participant
        public void Send(string recipient, string message)
        {
            Chatroom.Send(Name, recipient, message);
        }

        // Receives message from given participant
        public virtual void Receive(string sender, string message)
        {
            Console.WriteLine($"{sender} to {Name}: '{message}'");
        }
    }
}