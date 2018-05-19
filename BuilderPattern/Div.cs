namespace ConsoleApp4
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
            return $"<div {style.ToString()}>{value}</div>";
        }
    }
}
