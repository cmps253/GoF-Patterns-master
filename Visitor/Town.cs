using System;

namespace Visitor
{
    public sealed class Town : IVisitable
    {
        public String Name { get; set; }
        public double Elevation { get; set; }
        public int Population { get; set; }

        public Town(String name, double elevation)
        {
            this.Name= name;
            this.Elevation = elevation;
        }

        public override String ToString()
        {
            return "Town [name=" + Name + ", elevation=" + Elevation + "]";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public Town(Town another)
        {
            this.Name = another.Name;
            this.Elevation = another.Elevation;
            this.Population = another.Population;
        }
    }
}