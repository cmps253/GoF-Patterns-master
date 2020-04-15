using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamParlor
{
    public class IceCreamServing
    {
        public Container container;
        public List<Scoop> Scoops = new List<Scoop>();
        public List<Toping> Topings = new List<Toping>();
        IceCreamServing(Container container)
        {
            this.container = container;
        }
        public static IceCreamServing CreateInstance(Container container) => new IceCreamServing(container);
        //container (cub or a cone)
        //icream (flavors)
        //topings
    }
}
