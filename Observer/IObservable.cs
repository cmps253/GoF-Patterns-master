namespace Observer
{
    interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

}