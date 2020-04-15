using System;

namespace CMPS253.GoFPatterns.Behavioral.Visitor2
{
    class PaintVisitor : IVisitor
    {
        public void Visit(IVisitable visitable)
        {
            var room = visitable as Room;
            Console.WriteLine($"Painting room : {room.Name}");
        }
    }
}
