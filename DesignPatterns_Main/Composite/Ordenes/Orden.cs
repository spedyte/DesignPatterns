using Composite.Producto.Abstractos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Composite.Ordenes
{
    public class Orden
    {
        private long orderId;
        private string customer;

        private List<AbstractProduct> productos;

        public long OrderId { get => orderId; set => orderId = value; }
        public string Customer { get => customer; set => customer = value; }
        public List<AbstractProduct> Productos { get => productos; set => productos = value; }

        public Orden(long orderId,string customer)
        {
            this.orderId = orderId;
            this.customer = customer;
            this.productos = new List<AbstractProduct>();
        }


        public void addProduct(AbstractProduct producto)
        {
            this.productos.Add(producto);
        }

        public double getTotal()
        {
            double total = 0;
            foreach (var producto in productos)
            {
                total += producto.getPrice();
            }
            return total;
        }


        public void printOreder() {

            System.Console.WriteLine($"Orden del cliente:: {this.customer}");
            foreach (var producto in this.productos)
            {
                producto.printorder();
            }
            System.Console.WriteLine($"Total::: {this.getTotal()}");
        }
    }
}
