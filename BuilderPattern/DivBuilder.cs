namespace CMPS253.GoFPatterns.Creational.Builder
{
    public class DivBuilder
    {
        Div div;

        DivBuilder(string value)
        {
            div = new Div(value);
        }

        public static DivBuilder CreateInstance(string value)
        {
            return new DivBuilder(value);
        }

        public DivBuilder AddStyle(Style style)
        {
            div.style = style;
            return this;
        }

        public Div Build()
        {
            return div;
        }
    }
}
