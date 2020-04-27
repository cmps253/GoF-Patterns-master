namespace IceCreamParlor.Toppings
{
    public class ChocoFlakesTopping : BaseTopping
    {
        public override string Topping => "ChocoFlakes";
        public static ChocoFlakesTopping Instance => new ChocoFlakesTopping();
    }
}
