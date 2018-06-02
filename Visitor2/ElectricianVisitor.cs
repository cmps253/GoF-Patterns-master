using System;

namespace CMPS253.GoFPatterns.Behavioral.Visitor2
{
    public class ElectricianVisitor : IVisitor
    {
        public void Visit(IVisitable element)
        {
            var room = element as Room;
            Console.WriteLine($"Replacing burnt light bulbs for room {room.Name}");
        }
    }
}
