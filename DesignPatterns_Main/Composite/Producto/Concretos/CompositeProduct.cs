using Composite.Producto.Abstractos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Producto.Concretos
{
    public class CompositeProduct : AbstractProduct
    {
        private List<AbstractProduct> products;

        public CompositeProduct(string name, double price):base(name,price)
        {
            this.products = new List<AbstractProduct>();
        }

        public List<AbstractProduct> Products { get => products; set => products = value; }

        public void AddProduct(AbstractProduct product) {
            products.Add(product);
        }
        public void RemoveProduct(AbstractProduct product) {
            products.Remove(product);
        }

        public override double getPrice()
        {
            double price = 0;
            foreach (var producto in products)
            {
                price += producto.getPrice();
            }
            return price;
        }

        public override void printorder()
        {
            System.Console.WriteLine($"Package:: {this.Name} ==> {this.getPrice()}");
            foreach (var current in products)
            {
                current.printorder();
            }
            System.Console.WriteLine("-------Fin Paquete---");
        }
    }
}
