using System;

namespace CMPS253.GoFPatterns.Behavioral.Mediator
{
    public class Participant
    {
        public Chatroom Chatroom { get; internal set; }
        public string Name { get; private set; }

        // Constructor
        public Participant(string name)
        {
            this.Name = name;
        }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: '{message}'");
        }
    }
}