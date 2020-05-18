using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Composite.Producto.Abstractos
{
    public abstract class AbstractProduct
    {

        private string name;
        private double price;

        public AbstractProduct(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get => name; set => name = value; }
        public  double Price { get => price; set => price = value; }

        public virtual double getPrice() {
            return this.price;
        }

        public virtual void printorder()
        {
            System.Console.WriteLine($"    {this.name} --- ${this.price}");
        }
    }
}
