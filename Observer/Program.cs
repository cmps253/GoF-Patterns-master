namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    class MainApp
    {
        static void Main()
        {
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Fouad"));
            ibm.Attach(new Investor("Nabil"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }
    }
}