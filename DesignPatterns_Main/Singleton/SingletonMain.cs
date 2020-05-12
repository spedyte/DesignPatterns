using System;

namespace Singleton
{
    public class SingletonMain
    {
        public SingletonMain()
        {
            /*
          TIPO  DE PATRON: Creacional (Tipo de patron utilizado para crear los objetos)

          OBJETIVO :: Singleton solo puede tener 1 sola instancia pra toda la aplicacion de una determinada clase.
                      Este patron permite tener 1 referencia global al objeto, por lo que puede ser accedido desde 
                      cualquier parte de la aplicacion

          TIPS: Cuando tener mas de una instancia del objeto es perjudicial

          ESCENARIO: Se requiere de una aplicacion que en un inicio cargue UNA CONFIGURACION global, que estara 
                      disponible para todos los modulos que conforman el sistema, por lo tanto si un modulo cambia
                      la configuracion el resto de modulo veran dichos cambios.

          IMPLEMENTACION: La implementacion del patron se llama desde la clase  ..... Configuracion

            CUIDADO:  Si la aplicacion corre en cluster este singleton puede no ser el unico, se debe revisar la tecbologia
                        de sincornizacion de objetos para poder asegurar que sea una sola instancia.
         */
        }

        public void Run()
        {
            Configuracion.Configuracion config1 = Configuracion.Configuracion.getInstance();
            Configuracion.Configuracion config2= Configuracion.Configuracion.getInstance();

            Console.WriteLine($"Test... Las 2 instancias de Configuracion son iguales:::  => {config1==config2}");

            config1.AppName = "New App Name";
            Console.WriteLine($"Config 1. AppNAme => {config1.AppName}");
            Console.WriteLine($"Config 2. AppNAme => {config2.AppName}");

            Console.WriteLine($"Test... Las 2 instancias de Configuracion son iguales:::  => {config1 == config2}");

            config1 = null;
            config2 = null;

            config1 = Configuracion.Configuracion.getInstance();
            config2 = Configuracion.Configuracion.getInstance();

            Console.WriteLine($"Test... Las 2 instancias de Configuracion son iguales:::  => {config1 == config2}");
            Console.WriteLine($"Config 1. AppNAme => {config1.AppName}");
            Console.WriteLine($"Config 2. AppNAme => {config2.AppName}");
        }
    }
}
