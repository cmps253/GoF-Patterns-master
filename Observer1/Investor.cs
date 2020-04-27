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
            if (stock.getPrice() <= 120)
            {
                Console.WriteLine($"{_name}: {stock.getSymbol()} fell to {stock.getPrice()}, Buy!!");

            }
            else if (stock.getPrice() > 120)
            {
                Console.WriteLine($"{_name}: {stock.getSymbol()} rose to {stock.getPrice()}, Sell!!");
            }
        }
    }
}