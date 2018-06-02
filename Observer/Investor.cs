using System;
namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    class Investor : IInvestor
    {
        private string _name;
        private Stock Stock { get; set; }

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price:C}");
        }
    }
}