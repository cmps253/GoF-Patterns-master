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
        private IceCream serving;
        IceCreamBuilder(BaseIceCreamContainer container)
        {
            serving = IceCream.CreateInstance(container);
        }
        public static IceCreamBuilder CreateInstance(BaseIceCreamContainer container) => new IceCreamBuilder(container);

        public IceCreamBuilder SetSize(BaseIceCreamContainer.ContainerSize size)
        {
            if(serving==null)
            serving.Container.Size = size;
            return this;
        }
        public IceCreamBuilder AddScoop(BaseScoop scoop)
        {
            serving.Scoops.Add(scoop);
            return this;
        }

        public IceCreamBuilder AddTopping(BaseTopping toping)
        {
            serving.Toppings.Add(toping);
            return this;
        }


        public IceCream Build() => serving;
    }
}
