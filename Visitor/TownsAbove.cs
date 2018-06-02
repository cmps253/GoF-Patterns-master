using System;

namespace CMPS253.GoFPatterns.Behavioral.Visitor
{
    public class TownsAbove : IVisitor
    {
        int elevation;
        public TownsAbove(int elevation)
        {
            this.elevation = elevation;
        }
        public void Visit(IVisitable element)
        {
            var town = element as Town;
            if (town.Elevation >= elevation)
            {
                Console.WriteLine(town);
            }
        }
    }
}
