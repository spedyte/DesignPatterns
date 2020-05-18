using Composite.Ordenes;
using Composite.Producto.Concretos;
using System;

namespace Composite
{
    public class CompositeMain
    {
        public CompositeMain()
        {
            /*
          TIPO  DE PATRON: Estructural (Tipo de patron utilizado )

          OBJETIVO :: Es utilizado cuando se tiene que crear estructuras compuestas a partir de otras estructuras 
                        mas pequeñas, usando recursividad y estructuras anidadas por ejemplo de arbol.

          TIPS: Cuando se tienen estructuras complejas que pueden dividirse en elementos mas pequeños, los cuales estan 
                muy relacionados entre sí, tanto en funcionamiento como en estructura, el cliente no debe ser capaz de
                diferenciar de si se consume un componente simple o compuesto ya que esto queda agrupado por la implementacion
                del patron.

          ESCENARIO: Se requiere de un sistema de punto de venta donde un usuario puede comprar productos por pieza o por 
                    paquetes del mismo produtco. Se pueden crear ordenes de venta con 1 o mas productos.
                    El precio de un paquete es la suma del precio unitario de cada producto dentro del paquete
                    No debe existir diferencia entre la forma de tratar a los productos como a los paquetes
                    El precio de un producto, en caso de ser un producto compuesto, será el total de la suma de sus productos
                    internos tanto compuestos como simples.

          IMPLEMENTACION: La implementacion del patron se llama desde la clase  ..... AbstractProduct, CompositeProduct y SimpleProducto
         */
        }

        public void Run()
        {

            //Productos simples
            SimpleProduct ram4gb = new SimpleProduct("RAM 4GB","Kingston",750);
            SimpleProduct ram8gb = new SimpleProduct("RAM 8GB", "Adata", 1000);
            SimpleProduct disc500Gb = new SimpleProduct("Disco duro 500GB", "WesternDigital", 1500);
            SimpleProduct disc1Tb = new SimpleProduct("Disco duro 1 TB", "Toshiba", 2000);
            SimpleProduct cpuAMD = new SimpleProduct("Cpu AMD phenom", "AMD", 4000);
            SimpleProduct cpuIntel = new SimpleProduct("Cpu Intel Lake", "Intel", 4500);
            SimpleProduct bigGabinete = new SimpleProduct("Gabinete grande", "GabGRande", 2200);
            SimpleProduct pequeGabinete = new SimpleProduct("Gabinete pequenio", "GabPequenio", 2000);
            SimpleProduct monitor20inch = new SimpleProduct("Monitor 20 pulgadas", "DELL", 1500);
            SimpleProduct monitor30inch = new SimpleProduct("Monitor 30 pulgadas", "HP", 2000);
            SimpleProduct simpleMouse = new SimpleProduct("Mouse sencillo", "Loitech", 150);
            SimpleProduct gamerMouse = new SimpleProduct("Mouse gamer", "Alien", 750);
            SimpleProduct keyBoard = new SimpleProduct("Teclado", "Acme", 100);

            //Producots compuestos
            CompositeProduct keyBoardAndMouse = new CompositeProduct("KeyBoard & mouse ", 0);
            keyBoardAndMouse.AddProduct(simpleMouse);//150
            keyBoardAndMouse.AddProduct(keyBoard);//100

            CompositeProduct package1 = new CompositeProduct("Desktop pc", 0);
            package1.AddProduct(ram4gb);//750
            package1.AddProduct(disc500Gb);//1500
            package1.AddProduct(cpuIntel);//4500
            package1.AddProduct(keyBoardAndMouse);//250

            Orden orden = new Orden(1, "Alex");
            orden.addProduct(package1);
            orden.addProduct(pequeGabinete);
            orden.printOreder();




        }
    }
}
