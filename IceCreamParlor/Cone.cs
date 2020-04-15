namespace IceCreamParlor
{
    public class Cone : Container
    {
        public enum DoughType
        {
            SugarCone,
            WaffleCone
        }

        DoughType doughType;
        Cone(DoughType doughType)
        {
            this.doughType = doughType;
        }
        public static Cone CreateInstance(DoughType doughType) => new Cone(doughType);
        
        //programming pleasantness
        public static Cone WaffleCone => new Cone(DoughType.WaffleCone);
        public static Cone SugarCone => new Cone(DoughType.SugarCone);
    }
}