using FactoryMethod.Adaptadores.Abstractas;
using FactoryMethod.DBSimulation.Entidades;
using FactoryMethod.Factory;
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
    public class FactoryMethodMain
    {
        public FactoryMethodMain()
        {
            /*
             TIPO  DE PATRON: Creacional (Tipo de patron utilizado para crear los objetos)
             
             OBJETIVO :: Factory Method permite la creacion de objetos de un subtipo determinado a traves de una clase Factory.

             EJEMPLO :: Por ejemplo en un videojuego el usuario puede usar un joystick  o el teclado y pudiera ser que cada device
             tiene un controlador diferente, aqui el patron desacopla el videojuego del control a utilizar.
             
             TIPS: Cuando tenemos varios IFs o SWITCH para crear objetos de cierto tipo.
                   Cuando no sabemos en tiepo de diseño la subclase que se utilizará

             ESCENARIO: Requerimos una conexion a un usuario poder trabajar con 2 Base de datos Diferentes, por ejemplo Oracle y MySQL
             
            IMPLEMENTACION: La implementacion del patron se llama desde la clase ProductoDAO
            */
        }

        public void Run() {
            //Creamos un producto
            Producto prod1 = new Producto() { Id=1,Nombre="producto 1",Descripcion="desc prod 1"};

            //Agregamos el producto a la DBSimulada mediante un DAO que cuenta con un adapter y no depende de una implementacion
            //en concreto
            var tipoDB= Constantes.Enumeraciones.DBTypeDB.MYSQL;
            ProductoDAO productDAO = new ProductoDAO(tipoDB);//  <- Este valor permite el switch entre Oracle y MySQL simulados
            Console.WriteLine($"Insertando en :: {tipoDB}");
            productDAO.saveProduct(prod1);

            //Consulta de los productos desde mediante un DAO al adapter definido anteriormente mediante la enumeracion
            Console.WriteLine($"Consultando proudcots de:: {Constantes.Enumeraciones.DBTypeDB.MYSQL}");
            var products = productDAO.getAllProductos();

            Console.WriteLine("::::::::::::::::::   PRODUCTOS::::::::::::::::::::::::::");
            foreach (var product in products)
            {
                Console.WriteLine($" {product.ToString()}");
            }
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }
    }
}
