using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Behavioral.Mediator
{
    public class Chatroom : BaseChatroom
    {
        Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string sender, string recipient, string message)
        {
            Participant participant = _participants[recipient];

            if (participant != null)
            {
                participant.Receive(sender, message);
            }
        }
    }
}