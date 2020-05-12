using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.DBSimulation.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }

        public int Id{ get; set; }

        public string Descripcion { get; set; }

        public Producto()
        {

        }

        public override string ToString()
        {
            return $"Id:: {this.Id}  - Name :: {this.Nombre} - Descripcion ::  {this.Descripcion}";
        }
    }
}
