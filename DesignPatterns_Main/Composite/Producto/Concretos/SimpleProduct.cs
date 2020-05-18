using Composite.Producto.Abstractos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Composite.Producto.Concretos
{
    public class SimpleProduct : AbstractProduct
    {
        private string brand;

        //Con la instruccion BASE llamamos al super constructor de la clase abstracta
        public SimpleProduct(string brand,string name,double price):base(name,price)
        {
            this.Brand = brand;
        }

        public string Brand { get => brand; set => brand = value; }
    }
}
