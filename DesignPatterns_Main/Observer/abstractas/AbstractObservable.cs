using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.abstractas
{
    public abstract class AbstractObservable : IObservable
    {
        private readonly List<IObserver> observers = new List<IObserver>();


        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notifyAll(string propiedad, Object source)
        {
            foreach (var obs in observers)
            {
                obs.notify(propiedad, source);
            }
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
