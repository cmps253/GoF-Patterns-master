namespace IceCreamParlor.Toppings
{
    public class KitKatTopping : BaseTopping
    {
        public override string Topping => "KitKat";
        public static KitKatTopping Instance => new KitKatTopping();
    }
}
