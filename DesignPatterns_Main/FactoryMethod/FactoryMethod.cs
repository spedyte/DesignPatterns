using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// Clase que lanza el escenario donde se implementa el Patron Factory Method.
    /// 
    /// Armando Castaneda - Mayo 2020
    /// </summary>
    public class FactoryMethod
    {
        public FactoryMethod()
        {
            /*
             TIPO  DE PATRON: Creacional (Tipo de patron utilizado para crear los objetos)
             
             OBJETIVO :: Factory Method permite la creacion de objetos de un subtipo determinado a traves de una clase Factory.

             EJEMPLO :: Por ejemplo en un videojuego el usuario puede usar un joystick  o el teclado y pudiera ser que cada device
             tiene un controlador diferente, aqui el patron desacopla el videojuego del control a utilizar.
             
             TIPS: Cuando tenemos varios IFs o SWITCH para crear objetos de cierto tipo.
                   Cuando no sabemos en tiepo de diseño la subclase que se utilizará

             ESCENARIO: Requerimos una conexion a un usuario poder trabajar con 2 Base de datos Diferentes, por ejemplo Oracle y MySQL
             */
        }

        public void Run() {
            Console.WriteLine("Iniciando ->  FactoryMethod ....");



            Console.WriteLine("Finalizando ->  FactoryMethod ....");
        }
    }
}
