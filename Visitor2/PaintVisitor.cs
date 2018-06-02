using System;

namespace CMPS253.GoFPatterns.Behavioral.Visitor2
{
    class PaintVisitor : IVisitor
    {
        public void Visit(IVisitable element)
        {
            var room = element as Room;
            Console.WriteLine($"Painting room : {room.Name}");
        }
    }
}
