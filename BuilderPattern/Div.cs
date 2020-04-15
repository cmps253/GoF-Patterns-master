namespace CMPS253.GoFPatterns.Creational.Builder
{
    public class Div
    {
        string value;
        public Style style;

        public Div(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"<div {style?.ToString()}>{value}</div>";
        }
    }
}
