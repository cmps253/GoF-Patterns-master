namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    //an observer gets updated whenever an observable changes state
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}
