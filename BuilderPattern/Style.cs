namespace CMPS253.GoFPatterns.Creational.Builder
{
    public class Style
    {
        public string Color;
        public string BackColor;
        public float? FontSize;
        public string RawStyle => $"color:{Color};background-color:{BackColor};font-size:{FontSize}px;";
        public static string Stringify(string s) => $"style='{s}'";
        public override string ToString() => Stringify(RawStyle);
        public Style Add(Style that)
        {
            string color= this.Color ?? that.Color;
            string backColor= this.BackColor ?? that.BackColor;
            float? fontSize = this.FontSize ?? that.FontSize;
            return new Style() { Color = color, BackColor = backColor, FontSize = fontSize };
        }
    }
}
