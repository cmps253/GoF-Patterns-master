using System;

namespace CMPS253.GoFPatterns.Decorator
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
