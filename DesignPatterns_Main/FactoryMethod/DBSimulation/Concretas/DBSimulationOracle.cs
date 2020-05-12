using FactoryMethod.DBSimulation.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace FactoryMethod.DBSimulation.Concretas
{
    public class DBSimulationOracle : DBSimulation.Abstractas.DBSimulation
    {
        public DBSimulationOracle()
        {
            this.Productos = new List<Producto>();
            Console.WriteLine("Simulando Oracle......");
        }
    }
}
