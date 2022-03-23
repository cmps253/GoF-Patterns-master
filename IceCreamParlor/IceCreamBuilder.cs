using IceCreamParlor.Containers;
using IceCreamParlor.Flavors;
using IceCreamParlor.Toppings;

namespace IceCreamParlor
{
    /// <summary>
    /// This class has a single responsibility that of creating an instance of an IceCreamServing
    /// </summary>
    public class IceCreamBuilder
    {
        private IceCream _serving;
        IceCreamBuilder(BaseIceCreamContainer container)
        {
            _serving = IceCream.CreateInstance(container);
        }
        public static IceCreamBuilder CreateInstance(BaseIceCreamContainer container) => new IceCreamBuilder(container);

        public IceCreamBuilder SetSize(BaseIceCreamContainer.ContainerSize size)
        {
            if(_serving==null)
            _serving.Container.Size = size;
            return this;
        }
        public IceCreamBuilder AddScoop(BaseScoop scoop)
        {
            _serving.Scoops.Add(scoop);
            return this;
        }

        public IceCreamBuilder AddTopping(BaseTopping toping)
        {
            _serving.Toppings.Add(toping);
            return this;
        }


        public IceCream Build() => _serving;
    }
}
