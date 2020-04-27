namespace IceCreamParlor.Flavors
{
    public abstract class BaseScoop
    {
        public abstract string Flavor { get; }
        public override string ToString() => Flavor;
    }
}