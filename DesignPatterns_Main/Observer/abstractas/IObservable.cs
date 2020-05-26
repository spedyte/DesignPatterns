using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.abstractas
{
    public interface IObservable
    {
        public void notifyAll(string propiedad, Object source);

        public void addObserver(IObserver observer);

        public void removeObserver(IObserver observer);

    }
}
