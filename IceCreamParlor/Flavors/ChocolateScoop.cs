namespace IceCreamParlor.Flavors
{
    public class ChocolateScoop : BaseScoop
    {
        public override string Flavor => "Chocolate";
        public static ChocolateScoop Instance => new ChocolateScoop();
    }
}
