namespace IceCreamParlor.Flavors
{
    public class VanillaScoop : BaseScoop
    {
        public override string Flavor => "Vanilla";
        public static VanillaScoop Instance => new VanillaScoop();
    }
}
