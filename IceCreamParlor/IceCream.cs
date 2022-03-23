using IceCreamParlor.Containers;
using IceCreamParlor.Flavors;
using IceCreamParlor.Toppings;
using System.Collections.Generic;
using System.Text;

namespace IceCreamParlor
{
    public class IceCream
    {
        public BaseIceCreamContainer Container;
        public List<BaseScoop> Scoops = new List<BaseScoop>();
        public List<BaseTopping> Toppings = new List<BaseTopping>();
        IceCream(BaseIceCreamContainer container)
        {
            this.Container = container;
        }
        internal static IceCream CreateInstance(BaseIceCreamContainer container) => new IceCream(container);
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Container: {Container}\n");
            if (Container is Cone)
            {
                sb.Append($"Dough: {((Cone)Container).DoughType}\n");
            }
            sb.Append($"{Scoops.Count} scoop");
            if (Scoops.Count != 1)
            {
                sb.Append("s");
            }
            sb.Append(":\n");
            
            foreach (var scoop in Scoops)
            {
                sb.Append($"\t{scoop}\n");
            }

            sb.Append($"{Toppings.Count} topping");
            if (Toppings.Count != 1)
            {
                sb.Append("s");
            }
            sb.Append(":\n");

            foreach (var topping in Toppings)
            {
                sb.Append($"\t{topping}\n");
            }

            return sb.ToString();
        }
    }
}