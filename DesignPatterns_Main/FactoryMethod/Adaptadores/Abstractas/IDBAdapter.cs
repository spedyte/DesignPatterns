using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Adaptadores.Abstractas
{
    public interface IDBAdapter
    {
        public DBSimulation.Abstractas.DBSimulation getConnection();
    }
}
