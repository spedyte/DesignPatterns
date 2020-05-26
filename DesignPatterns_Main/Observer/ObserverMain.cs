using Microsoft.VisualBasic;
using Observer.concretas.observables;
using Observer.concretas.observadores;
using System;
using System.Globalization;

namespace Observer
{
    public class ObserverMain
    {
        public ObserverMain()
        {
            /*
          TIPO  DE PATRON: Comportamiento (Tipo de patron utilizado )

          OBJETIVO :: Permite que una serie de objetos puedan observar los cambios de un objeto, así cuando el
                    objeto observado se actualice, el observer notificará a todos los interesados de forma inmediata.

          TIPS: Usarlo cuando se requiera que un conjunto de objetos esten enterados sobre los cambios realizados por otro
                objeto.
                Cuando se requiera desacolplar el objeto analizado de los observadores, permitiendo la variacion de ambas
                partes

          ESCENARIO: Desarrollar una aplicacion capaz de gestionar su configuración global(obejto observable), de tal forma
                    que cualquier proceso pueda recuperarla y actualizarla.
                    Es necesario que cualquier interesado(observador) de los cambios de la configuracion pueda ser 
                    notificado de cualquier cambio para actuar de la mejor manera frente al cambio.

          IMPLEMENTACION: La implementacion del patron se llama desde la clase ... IObservable,AbstractObservable y 
          ConfigurationManager

         */
        }

        public void Run()
        {

            ConfigurationManager configMgr = ConfigurationManager.getInstance();

            ObserverA obsA = new ObserverA();
            ObserverB obsB = new ObserverB();
            configMgr.addObserver(obsA);
            configMgr.addObserver(obsB);

            configMgr.CultureInfo= new CultureInfo("es-MX");
                        
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            configMgr.Numberformat = nfi;

            Console.WriteLine("fin....");

        }
    }
}
