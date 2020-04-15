namespace IceCreamParlor
{
    /// <summary>
    /// This class has a single responsibility that of creating an instance of an IceCreamServing
    /// </summary>
    public class IceCreamServingBuilder
    {
        private IceCreamServing serving;
        IceCreamServingBuilder(Container container)
        {
            serving = IceCreamServing.CreateInstance(container);
        }
        public static IceCreamServingBuilder CreateInstance(Container container) => new IceCreamServingBuilder(container);

        public IceCreamServingBuilder AddScoop(Scoop scoop)
        {
            serving.Scoops.Add(scoop);
            return this;
        }

        public IceCreamServingBuilder AddToping(Toping toping)
        {
            serving.Topings.Add(toping);
            return this;
        }

        public IceCreamServing Build() => serving;
    }
}
