using System;
using System.Collections.Generic;
using System.Linq;

namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    public class Course : IObservable
    {
        private List<IObserver> _waitingList = new List<IObserver>();
        private List<IObserver> _registeredStudents = new List<IObserver>();

        protected int MaxCapacity;

        #region IObservable

        public void Notify()
        {
            Random rnd=new Random();
            var randomized = _waitingList.ToArray().OrderBy(x => rnd.Next()).ToArray();

            foreach (IObserver observer in randomized)
            {
                observer.Update(this);
            }
        }
        #endregion

        public string Name;
        public Course(string name, int maxCapacity)
        {
            Name = name;
            MaxCapacity = maxCapacity;
            _capacity = maxCapacity;
        }

        private int _capacity;
        public int GetCapacity()
        {
            return _capacity;
        }

        public bool Register(IObserver observer)
        {
            if (_capacity > 0)
            {
                --_capacity;
                _registeredStudents.Add(observer);
                if (_waitingList.Contains(observer))
                {
                    _waitingList.Remove(observer);
                }
                Console.WriteLine($"{((Student)observer).Name} successfully registered for {this.Name}, capacity is now {_capacity}");
                return true;
            }
            if (!_waitingList.Contains(observer))
            {
                _waitingList.Add(observer); //todo remove the observer from the waiting list after dropping, list
            }
            Console.WriteLine($"{((Student)observer).Name} was **denied registration** for {this.Name} as capacity is {_capacity}");

            return false;
        }
        public void Drop(IObserver observer)
        {
            Console.Write($"\n{((Student)observer).Name} dropped {this.Name} ");

            if (_registeredStudents.Contains(observer))
            {
                _registeredStudents.Remove(observer);
                _waitingList.Remove(observer);
                if (_capacity++ == 0)
                {
                    Console.WriteLine($"capacity is now {_capacity}");
                    Notify();
                }
                else
                {
                    Console.WriteLine($"capacity is now {_capacity}");
                }
            }
        }
        public override string ToString() => Name;
    }
}