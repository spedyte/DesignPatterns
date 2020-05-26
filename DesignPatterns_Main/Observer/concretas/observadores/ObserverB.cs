using Observer.abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.concretas.observadores
{
    public class ObserverB : IObserver
    {
        public void notify(string propiedad, Object source)
        {
            if (propiedad.Equals("numberforamt"))
                Console.WriteLine($"{propiedad} cambió en objeto {nameof(source)} - Observer B");
        }
    }
}
