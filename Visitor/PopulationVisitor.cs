using System;

namespace Visitor
{
    public class PopulationVisitor : IVisitor
    {
        public void Visit(IVisitable element)
        {
            Town town = element as Town;
            town.Population += 1000;
            Console.WriteLine("{0} {1}'s new population: {2}", town.GetType().Name, town.Name, town.Population);
        }
    }
}