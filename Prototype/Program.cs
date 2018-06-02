using System.Collections.Generic;

namespace CMPS253.GoFPatterns.Creational.Prototype
{
    class MainApp
    {
        static void Main()
        {
            var red = new Color(255, 0, 0);
            var red2 = red.Clone() as Color;
            red2.Blue = 255;
            System.Console.WriteLine(red);
            System.Console.WriteLine(red2);
            return;

            var colors = new Dictionary<string, ICloneable>();

            colors.Add("green", new Color(0, 255, 0));
            colors.Add("blue", new Color(0, 0, 255));

            // User adds personalized colors
            colors.Add("angry", new Color(255, 54, 0));
            colors.Add("peace", new Color(128, 211, 128));
            colors.Add("flame", new Color(211, 34, 20));

            // User clones selected colors
            Color newred = colors["red"].Clone() as Color;
            Color color2 = colors["peace"].Clone() as Color;
            Color color3 = colors["flame"].Clone() as Color;

            red = colors["red"] as Color;

            red.Green = 255;

            System.Console.WriteLine(newred);
            System.Console.WriteLine(red);

        }
    }
}