using FactoryMethod.Adaptadores.Abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Adaptadores.Concretas
{
    public class OracleAdapter : IDBAdapter
    {
        public DBSimulation.Abstractas.DBSimulation dbSimulada { get; set; }

        public OracleAdapter()
        {
            dbSimulada = new DBSimulation.Concretas.DBSimulationOracle();
            dbSimulada.Source = "Oracle";
        }
        public DBSimulation.Abstractas.DBSimulation getConnection()
        {
            Console.WriteLine(dbSimulada.GetType().Name);
            return dbSimulada;
        }
    }
}
