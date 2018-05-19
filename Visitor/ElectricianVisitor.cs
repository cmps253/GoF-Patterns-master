using System;

namespace Visitor
{
    public class ElectricianVisitor : IVisitor
    {
        public void Visit(IVisitable element)
        {
            var room = element as Room;
            Console.WriteLine($"Turning the lights off for room {room.Name}");
        }
    }
}
