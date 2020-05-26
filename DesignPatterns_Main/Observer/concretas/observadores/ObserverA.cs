using Observer.abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.concretas.observadores
{
    public class ObserverA : IObserver
    {
        public void notify(string propiedad, Object source)
        {
            if(propiedad.Equals("cultureInfo"))
                Console.WriteLine($"{propiedad} cambió en objeto {nameof(source)} - Observer A");
        }
    }
}
