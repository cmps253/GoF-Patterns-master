namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM(120.00);
            ibm.Attach(new Investor("Fouad"));
            ibm.Attach(new Investor("Nabil"));

            ibm.setPrice(120.10);
            ibm.setPrice(121.00);
            ibm.setPrice(120.50);
            ibm.setPrice(120.75);
        }
    }
}
