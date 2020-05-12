using AbstractFactory.Servicios.Abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Servicios.Concretas.RestFull
{
    class ProductServiceRestFull : IProductService
    {
        public List<string> getProducts()
        {
            Console.WriteLine("ProductServiceRestFull.getProducts");
            List<string> results = new List<string>() { "Product REST 1", "Product REST 2", "Product REST 3" };
            return results;
        }
    }
}
