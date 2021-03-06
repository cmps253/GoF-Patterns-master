﻿namespace CMPS253.GoFPatterns.Behavioral.Observer
{
    //an observable maintains a list of observers and notifies them whenever its state changes
    public interface IObservable
    {
        bool Register(IObserver observer);
        void Drop(IObserver observer);
        void Notify();
    }
}