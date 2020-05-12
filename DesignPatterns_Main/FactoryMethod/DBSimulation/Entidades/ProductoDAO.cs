using FactoryMethod.Adaptadores.Abstractas;
using FactoryMethod.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static FactoryMethod.Constantes.Enumeraciones;

namespace FactoryMethod.DBSimulation.Entidades
{
    public class ProductoDAO
    {
        private IDBAdapter  adapter{ get; set; }

        public ProductoDAO(DBTypeDB type)
        {
            Console.WriteLine("Iniciando ->  FactoryMethod ....");
            //ToDo:: El adapter que implementa el patron en este punto requiere el tipo de la BD a crear
            //pero se puede hacer que el propio adapter lea desde un archivo de configuracion 
            //el valor para crear la BD correspondiente y asi no depender del paso del parametro
            //
            adapter = DBFactoryAdapter.getAdapter(type);
            Console.WriteLine("Finalizando ->  FactoryMethod ....");
        }
        public void saveProduct(Producto producto)
        {
            var db = adapter.getConnection();
            db.Productos.Add(producto);
        }

        public List<Producto> getAllProductos() {
            return adapter.getConnection().Productos;
        }
    }
}
