using Strategy.concretas;
using Strategy.util;
using System;

namespace Strategy
{
    public class StrategyMain
    {
        public StrategyMain()
        {
            /*
          TIPO  DE PATRON: Comportamiento (Tipo de patron utilizado )

          OBJETIVO :: Permite establecer en tiempode ejecucion el rol de comportamiento de una clase.
                    Strategy se basa en el polymorfismo para implementar una serie de comportamientos
                    que podran ser intercambiandos durante la ejecucion del programa, logrando con esto
                    que un objeto se pueda comportar de forma distinta segun la estrategia establecida

          TIPS: Las estrategias deben atacar el MISMO problema de una manera diferente. 
                Usarlo cuando se requiere que el comportamiento de una clase pueda variar segun el estado
                de la aplicacion o simplemente por configuracion.
                Cuando un conjunto de clases se diferencia unicament por su comportamiento. el comportamiento
                se podría extraer en una estrategia para despues ser establecida segun las circunstancias.
                

          ESCENARIO: Crear una aplicacion que permite cambiar dinamicamente el metodo de autenticacion, permitiendo
                    al administrador del sistema elegir el método por el cual serán autenticados los usuarios.
                    Para iniciar, se permitira la autenticación por medio de un archivo XML, autenticacion por BD
                    y usuario alojados en memoria, sin embargo, la aplicacion deberá estar lista para soportar nuevos
                    métodos de autenticación sin afectar el funcionamiento.

          IMPLEMENTACION: La implementacion del patron se llama desde la clase ... AuthProvider

         */
        }

        public void Run()
        {
            AuthProvider provider = new AuthProvider(new OnMemoryAuthstrategy());
            string userName = "oblancarte";
            string pwd = "1231";

            Principal userAutenticado=provider.authenticate(userName, pwd);
            Console.WriteLine(userAutenticado.ToString());

        }
    }
}
