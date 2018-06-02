using System;
using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Behavioral.Visitor
{
    class Towns
    {
        private List<Town> towns = new List<Town>();
        private List<IVisitor> visitors = new List<IVisitor>();

        public void Attach(Town town)
        {
            towns.Add(town);
        }

        public void Detach(Town town)
        {
            towns.Remove(town);
        }

        public void Accept(IVisitor visitor)
        {
            visitors.Add(visitor);
        }

        public void Visit()
        {
            foreach (Town town in towns)
            {
                foreach (var visitor in visitors)
                {
                    town.Accept(visitor);
                }
            }
            Console.WriteLine();
        }
    }
}
