using System;

namespace Prototype
{
    public class Color : ICloneable
    {
        public int Red;
        public int Green;
        public int Blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        // Create a shallow copy
        public ICloneable Clone()
        {
            //Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}",Red, Green, Blue);
            return this.MemberwiseClone() as ICloneable;

            var newcolor = new Color(Red, Green, Blue);
            return newcolor;
        }

        public override string ToString()
        {
            return $"({Red},{Green},{Blue})";
        }
    }
}