using System;

namespace Visitor
{
    public class ElevationVisitor : IVisitor
    {
        public void Visit(IVisitable element)
        {
            Town town = element as Town;
            town.Elevation += 1000;
            Console.WriteLine("{0} {1}'s new elvation: {2}", town.GetType().Name, town.Name, town.Elevation);
        }
    }
}
