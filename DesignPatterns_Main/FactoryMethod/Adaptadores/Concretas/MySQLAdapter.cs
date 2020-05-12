using FactoryMethod.Adaptadores.Abstractas;
using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.DBSimulation.Abstractas;

namespace FactoryMethod.Adaptadores.Concretas
{
    public class MySQLAdapter : IDBAdapter
    {
        public DBSimulation.Abstractas.DBSimulation dbSimulada { get; set; }

        public MySQLAdapter()
        {
            dbSimulada = new DBSimulation.Concretas.DBSimulationMySQL();
            dbSimulada.Source = "MySQL";
        }
        public DBSimulation.Abstractas.DBSimulation getConnection()
        {
            Console.WriteLine(dbSimulada.GetType().Name);
            return dbSimulada;
        }
    }
}
