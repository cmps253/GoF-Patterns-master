namespace IceCreamParlor.Containers
{
    public abstract class Cone : BaseIceCreamContainer
    {
        public abstract string DoughType { get; }

        public override string ContainerType => "Cone";
        public override string ToString() => $"{DoughType} Cone";
    }
}