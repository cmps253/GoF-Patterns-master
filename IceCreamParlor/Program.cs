using System;

namespace IceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CMPS253 Ice Cream Parlor");
            IceCreamServing builder  = 
                IceCreamServingBuilder.CreateInstance(Cone.SugarCone)
                .AddScoop(Scoop.ChocolateScoop)
                .AddScoop(Scoop.StrawberryScoop)
                .AddScoop(Scoop.VanillaScoop)
                .AddToping(Toping.ChocoFlakes)
                .AddToping(Toping.KitKat)
                .Build();
        }
    }
}