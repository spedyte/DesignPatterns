using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.abstractas
{
    public interface IObserver
    {
        public void notify(string propiedad,Object source);
    }
}
