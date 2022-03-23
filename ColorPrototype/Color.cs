using System;

namespace CMPS253.GoFPatterns.Creational.Prototype
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

        public Color(Color that) //copy constructor
        {
            this.Red   = that.Red;
            this.Green = that.Green;
            this.Blue  = that.Blue;
        }
        // Create a shallow copy
        public ICloneable Clone()
        {
            //method1
            var newcolor = new Color(Red, Green, Blue);
            return newcolor;

            //method1
            return this.MemberwiseClone() as ICloneable;
        }

        public override string ToString()
        {
            return $"({Red},{Green},{Blue})";
        }
    }
}