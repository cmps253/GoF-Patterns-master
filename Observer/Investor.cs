using System;
namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    class Investor : IInvestor //investor is an observer
    {
        private string _name;
        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            if (stock.Price <= 120)
            {
                Console.WriteLine($"{stock.Symbol} fell to {stock.Price}, Buy!!");

            }
            else if (stock.Price > 120)
            {
                Console.WriteLine($"{stock.Symbol} rose to {stock.Price}, Sell!!");
            }
        }
    }
}