using Proxy.Abstractos;
using Proxy.Factory;
using System;

namespace Proxy
{
    public class ProxyMain
    {
        public ProxyMain()
        {
            /*
          TIPO  DE PATRON: Estructural (Tipo de patron utilizado )

          OBJETIVO :: Es utilizado como un intermediario entre el cliente y el objeto final, el cual permite
                        realizar acciones PREVIAS y POSTERIORES a la llamada del objeto final.

          TIPS: Es utilizado por lo general para controlar el acceso a un objeto final, aunque también es utilizado
                paraa hacer referencia a un objeto REMOTO o para resolver a DEMANDA un objeto de gran tamaño o
                costo en procesamiento o consume mucha memoria, por ejemplo JPA hace un sobre sobre la lista de entidades
                para realizar querys sobre entidades.

          ESCENARIO: Se rquiere de un portal para desarrollar procesos, cuyos procesos son ejecutados por usuarios autorizados,
                    deben ser auditadas dichas personas para saber cuando ejecutó un proceso
                    El cliente no sabe si es necesario ejecutar acciones previas o posteriores a la ejecucion de los procesos
                    pero requiere que el sistema este preparado para ello en un futuro .

          IMPLEMENTACION: La implementacion del patron se llama desde la clase ... ProcessExecutorProxy
                            El Proxy SIEMPRE debe ser creado con un FACTORY para asegurarnos que el cliente siempre
                            recibira un objeto proxy y no un objeto real
         */
        }

        public void Run()
        {
            IProcessExecutor process = ServiceFactory.createProcessExecutor();
            try
            {
                process.EjecuteProcess(1, "userAutorizado", "1234");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
