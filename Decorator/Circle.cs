using System;

namespace CMPS253.GoFPatterns.Structural.Decorator
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
