using System;
using System.Collections.Generic;
namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    public abstract class Stock : IObservable
    {
        #region Class fields and Constructor 
        private string _symbol;
        private double _price;

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }
        public string getSymbol()
        {
            return _symbol;
        }
        public void setSymbol(string symbol)
        {
            _symbol = symbol;
        }

        public double getPrice()
        {
            return _price;
        }
        #endregion

        #region Dealing with Observers
        private List<IInvestor> _investors = new List<IInvestor>();
        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }
        #endregion

        #region Notify observers when state (stock price) changes
        public void setPrice(double value)
        {
            if (_price != value)
            {
                _price = value;
                Notify();
            }
        }

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }
        #endregion
    }
}