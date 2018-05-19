using System;

namespace Visitor
{
    public class Politician : IVisitor
    {
        public void Visit(IVisitable element)
        {
            var town = element as Town;
            Console.WriteLine($"I promise good stuff for you people of {town.Name}");
        }
    }
}
