using System;

namespace Visitor
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
