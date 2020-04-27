namespace IceCreamParlor.Containers
{
    public abstract class BaseIceCreamContainer
    {
        public enum ContainerSize
        {
            Large,
            Medium,
            Small,
        }
        public ContainerSize Size { get; set; }
        public abstract string ContainerType { get; }

        public override string ToString() => $"{ContainerType}, size = {Size}";
    }
}