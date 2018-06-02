namespace CMPS253.GoFPatterns.Creational.Builder
{
    public class Style
    {
        public string Color;
        public string BackColor;
        public float FontSize;

        public override string ToString()
        {
            return $"style='color:{Color};background-color:{BackColor};font-size:{FontSize}em;'";
        }
    }
}
