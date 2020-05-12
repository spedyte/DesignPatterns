using FactoryMethod.DBSimulation.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.DBSimulation.Concretas
{
    public class DBSimulationMySQL : DBSimulation.Abstractas.DBSimulation
    {
        public DBSimulationMySQL()
        {
            this.Productos = new List<Producto>();
            Console.WriteLine("Simulando MySQL......");
        }
    }
}
