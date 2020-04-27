namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    //an observable maintains a list of observers and notifies them whenever its state changes
    public interface IObservable
    {
        void Attach(IInvestor observer);
        void Detach(IInvestor observer);
        void Notify();
    }
}