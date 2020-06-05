using Builder.dto;
using System;

namespace Builder
{
    public class BuilderMain
    {
        public BuilderMain()
        {
            /*
          TIPO  DE PATRON: Creacional (Tipo de patron utilizado para crear objetos)

          OBJETIVO :: Es utilizado cuando se requiere crear objetos complejos a través de uno más simple.
                      Estos objetos compuestos se requieren crear de forma repetida lo cual nos llevaria a
                      tener que establecer cada propiedad del objeto y puede empeorar si dichas propiedad a su vez
                      son objetos compuestos.

          TIPS: Cuando se requiere crear un mecanismo simple para crear objetos complejos.
                Cuando se requiere crear repetidamente objetos complejos.
                Cuando es necesario ocultar al usuario la complejidad de la creacion de un objeto determinado.

          ESCENARIO: Crear la estructura completa de un empleado con direccion, uno o varios telefonos y varios contactos
                    además de sus datos básicos, se debe crear de forma limpia y rapida, sin tener la necesida de crear
                    todos los objetos que lo componen y librandonos de conocer exactametne la logica de creacion,
                    el orden en que éstos deberán ser creados y cómo es que cada objeto se debe asociar a otro objeto.

          IMPLEMENTACION: La implementacion del patron se llama desde la clase  ..... Employee porque ahi se encuentra
                            la clase EmployeeBuilder
         */
        }

        public void Run()
        {
            Employee emp = new Employee.EmployeeBuilder() 
                .setName("Luis Perez Cruz") 
                .setGender("H") 
                .setAge(29)
                .setAddress("Aragón 189 int 404 col. Álamos, delegación Benito "
                + "Juarez", "México D.F.", "México", "03400")
                .addContacts("Rene Martinez", "1122334455", "123", "Casa", 
                "Chapultepect No. 123 Col. Militar", "México"
                , "México", "10023")
                .addContacts("Jaime Ramirez", "3344556677", null, "Celular")
                .addPhones("4567890234", null, "Celular")
                .addPhones("7788990099", null, "Casa")
                .Build();

            Console.WriteLine(emp);

        }
    }
}
