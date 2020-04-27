namespace IceCreamParlor.Toppings
{
    public class SprinklesTopping : BaseTopping
    {
        public override string Topping => "Sprinkles";
        public static SprinklesTopping Instance => new SprinklesTopping();
    }
}
