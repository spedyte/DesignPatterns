using Facade.abstractas;
using Facade.concretos;
using Facade.util;
using System;

namespace Facade
{
    public class FacadeMain
    {
        public FacadeMain()
        {
            /*
          TIPO  DE PATRON: Estructural (Tipo de patron utilizado )

          OBJETIVO :: Ocultar la complejidad de interactuar con un conjunto de subsistemas proporcionando una
                        interfarce de ALTO NIVEL, la cual se encarga de realizar la comunicacion con todos los
                        subsistemas  necesarios.

          TIPS: USar cuando interactuar con un conjunto de subsistemas es complicado y cuando queremos construir
                interfaces de ALTO NIVEL para nuestros usuarios y asi evitar errores de interpretacuion y implementacion
                por parte de los usuarios.

          ESCENARIO: Se debe agregar una nueva funcionalidad a un sistema para permitir los pagos en linea, al 
                    realizar el pago no solo se hace el cobro, sino también se deben afectar varios subsistemas para que
                    el pago sea aplicado correctamente y se le puede notificar al usuario sobre su pago exitoso.
                    Ejemplos de subsistemas afectados: Banco, facturacion, CRM del cliente y servidor de correo electronico.

          IMPLEMENTACION: La implementacion del patron se llama desde la clase ... 

         */
        }

        public void Run()
        {
            try
            {
                IPaymentFacade facade = new PayFacadeImple();
                PaymentRequest request = new PaymentRequest(1,500,"1234567890123456","Oscar Blancarte","10/2022","345");

                PaymentResponse response = facade.pay(request);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

        }
    }
}
