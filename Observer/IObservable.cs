namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

}