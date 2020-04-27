namespace IceCreamParlor.Flavors
{
    public class StrawberryScoop : BaseScoop
    {
        public override string Flavor => "Strawberry";
        public static StrawberryScoop Instance => new StrawberryScoop();
    }
}