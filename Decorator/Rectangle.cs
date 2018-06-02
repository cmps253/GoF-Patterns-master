using System;

namespace CMPS253.GoFPatterns.Structural.Decorator
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
