namespace CMPS253.GoFPatterns.Creational.Builder
{
    public class DivBuilder
    {
        Div _div;

        #region Constructors
        DivBuilder(string value)
        {
            _div = new Div(value);
        }

        public static DivBuilder CreateInstance(string value)
        {
            return new DivBuilder(value);
        } 
        #endregion

        public DivBuilder AddStyle(Style style)
        {
            _div.style = style;
            return this;
        }

        public Div Build() => _div;
    }
}
