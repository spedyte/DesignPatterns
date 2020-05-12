using AbstractFactory.AbstractFactory.Concretas;
using AbstractFactory.Servicios.Abstractas;
using System;

namespace AbstractFactory
{
    public class AbstractFactoryMain
    {
        public AbstractFactoryMain()
        {
            /*
          TIPO  DE PATRON: Creacional (Tipo de patron utilizado para crear los objetos)

          OBJETIVO :: Abstract Factory permite la creacion de un conjunto de clases llamadas familias.
                    Las familias son un conjunto de clases que busnca resolver la misma problematica pero con una 
                    implementacion diferente

          TIPS: Cuando NO SE CONOCE en tiempo de diseño, la familia de clases que se utilizaran en ejecucion
                Cuando es necesario cosntruir DIFERENTES  IMPLEMENTACIONES para solucionar unn MISMO PROBLEMA.

          ESCENARIO: Una aplicacion que se conecta a REST o a SOAP, cada familia implementa una solucion de forma diferente

          IMPLEMENTACION: La implementacion del patron se llama desde la clase  .....
         */
        }

        public void Run()
        {
            //llamamos al Abstract Factory que genera la Factory que a su vez crea la familia de Servicios 
            //es decir clases del tipo de Servicio enviado
            var tipo = Constantes.Constantes.ServiceType.SOAP;
            var abstractFactory = ServiceStackAbstractFactory.createServiceFactory(tipo);

            //Actualmente el tipo de servicio se pasa al createServiceFactory pero se puede leer ese valor desde
            //un archivo de configuracion o algo similar y dentro de ServiceStackAbsytractFactory se obtiene el valor,
            // y se crean los Services pertinentes al valor leido desde la configuracion


            IEmployeeService employeeService = abstractFactory.getEmployeeService();
            IProductService productService = abstractFactory.getProductService();

            Console.WriteLine($":::::::::::::::::::  EMPLEADOS   ({tipo})  :::::::::::::::::::");
            foreach (var employee in employeeService.getEmployee())
            {
                Console.WriteLine($"Empleado:: {employee}");
            }
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine($":::::::::::::::::::  PRUDCOTS   ({tipo})  :::::::::::::::::::");
            foreach (var producto in productService.getProducts())
            {
                Console.WriteLine($"Producto:: {producto}");
            }
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        }
    }
}
