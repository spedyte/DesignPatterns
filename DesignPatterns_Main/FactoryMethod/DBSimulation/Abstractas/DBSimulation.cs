using FactoryMethod.DBSimulation.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.DBSimulation.Abstractas
{
    public class DBSimulation
    {
        public List<Producto> Productos { get; set; }

        public string Source { get; set; }
    }
}
