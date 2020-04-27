using IceCreamParlor.Containers;
using IceCreamParlor.Flavors;
using IceCreamParlor.Toppings;
using System;

namespace IceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CMPS253 Ice Cream Parlor");

            IceCreamBuilder builder=null;

            Console.WriteLine("Would you like a cup(u) or a cone(o)?");
            string container = Console.ReadLine().ToLower();
            
            string doughtype = null;
            if(container=="o")
            {
                Console.WriteLine("What kind of a cone?");
                doughtype = Console.ReadLine().ToLower();
            }

            Console.WriteLine("What size of serving?");
            string size = Console.ReadLine().ToLower();
            //CLI client to be continued, complete it by first initializing an IceCreamBuilder then calling on its methods as you ask the user questions and get replies. Finally, build the ice cream serving and print it.

            //Fluent Interface
            IceCream IceCream  = 
                
                IceCreamBuilder.CreateInstance(new SugarCone())
                
                .AddScoop(ChocolateScoop.Instance)
                .AddScoop(StrawberryScoop.Instance)
                .AddScoop(VanillaScoop.Instance)
                .AddScoop(VanillaScoop.Instance)
                .AddScoop(StrawberryScoop.Instance)

                .AddTopping(ChocoFlakesTopping.Instance)
                .AddTopping(KitKatTopping.Instance)
                .AddTopping(SprinklesTopping.Instance)
                
                .Build();

            Console.WriteLine(IceCream);
        }
    }
}
