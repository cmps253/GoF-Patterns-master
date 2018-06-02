using System;

namespace CMPS253.GoFPatterns.Behavioral.Visitor
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
