namespace IceCreamParlor.Toppings
{
    public abstract class BaseTopping
    {
        public abstract string Topping { get; }
        public override string ToString() => Topping;
    }
}