using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Creational.Prototype
{
    class MainApp
    {
        static void Main()
        {
            var red1 = new Color(255, 0, 0);
            var red2 = red1.Clone() as Color;
            red2.Blue = 255;
            System.Console.WriteLine(red1);
            System.Console.WriteLine(red2);
            //return;

            var colors = new Dictionary<string, ICloneable>();
            colors.Add("red1", red1);
            colors.Add("green", new Color(0, 255, 0));
            colors.Add("blue", new Color(0, 0, 255));

            // User adds personalized colors
            colors.Add("angry", new Color(255, 54, 0));
            colors.Add("peace", new Color(128, 211, 128));
            colors.Add("flame", new Color(211, 34, 20));

            // User clones selected colors
            Color redCloned = colors["red1"].Clone() as Color;
            Color peaceCloned = colors["peace"].Clone() as Color;
            Color flameCloned = colors["flame"].Clone() as Color;

            red1 = colors["red1"] as Color;

            red1.Green = 255;

            System.Console.WriteLine(redCloned);
            System.Console.WriteLine(red1);
        }
    }
}