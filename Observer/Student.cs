namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    public class Student : IObserver
    {
        public string Name { get; private set; }
        public Student(string name)
        {
            Name = name;
        }
        public void Update(IObservable observable)
        {
            observable.Register(this);
        }
    }
}