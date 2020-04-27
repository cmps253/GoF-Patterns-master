namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    public interface IInvestor //investor is an observer, interested in knowing when the state of an observable changes
    {
        void Update(Stock stock); //Stock is the observable
    }
}