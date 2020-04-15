namespace IceCreamParlor
{
    public class Scoop
    {
        public enum FlavorType
        {
            Vanilla,
            Chocolate,
            Strawberry
        }
        public FlavorType Flavor { get; set; }
        public Scoop(FlavorType flavor)
        {
            this.Flavor = flavor;
        }
        public static Scoop ChocolateScoop => new Scoop(FlavorType.Chocolate);
        public static Scoop StrawberryScoop => new Scoop(FlavorType.Strawberry);
        public static Scoop VanillaScoop => new Scoop(FlavorType.Vanilla);
    }
}