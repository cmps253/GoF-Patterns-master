using System.Text;

namespace CMPS253.GoFPatterns.Creational.Builder
{
    public class StyleBuilder
    {
        Style style;
        StyleBuilder()
        {
            style = new Style();
        }

        public static StyleBuilder CreateInstance()
        {
            return new StyleBuilder();
        }

        public StyleBuilder AddColor(string color)
        {
            style.Color = color;
            return this;
        }
        public StyleBuilder AddBackColor(string color)
        {
            style.BackColor = color;
            return this;
        }
        public StyleBuilder AddFontSize(float size)
        {
            style.FontSize = size;
            return this;
        }

        public Style Build()
        {
            return style;
        }
    }
}
