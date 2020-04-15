namespace IceCreamParlor
{
    public class Toping
    {
        public TopingTypeEnum TopingType { get; set; }
        public enum TopingTypeEnum
        {
            ChocoFlakes,
            Sprinkles,
            KitKat
        }

        public static Toping ChocoFlakes => new Toping() { TopingType = TopingTypeEnum.ChocoFlakes };
        public static Toping Sprinkles => new Toping() { TopingType = TopingTypeEnum.Sprinkles };
        public static Toping KitKat => new Toping() { TopingType = TopingTypeEnum.KitKat };
    }
}
