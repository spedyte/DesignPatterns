using AbstractFactory.Servicios.Abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Servicios.Concretas.Soap
{
    public class ProductServiceSoap : IProductService
    {
        public List<string> getProducts()
        {
            Console.WriteLine("ProductServiceSoap.getProducts");
            List<string> results = new List<string>() { "Product Soap 1", "Product Soap 2", "Product Soap 3" };
            return results;
        }
    }
}
