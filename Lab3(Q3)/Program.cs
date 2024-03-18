using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q3_
{
        public class Product
        {
            private int productID;
            private string productName;
            private double price;
            private int QuantityInStock;

            //constructor
            public Product(int productId, string productName, double price, int quantityInStock)
            {
                this.productID = productID;
                this.productName = productName;
                this.price = price;
                this.QuantityInStock = quantityInStock;
            }

            public string getProductName()
            {
                return productName;
            }

            public double getPrice()
            {
                return price;
            }

            public int getQuantityInStock()
            {
                return QuantityInStock;
            }

            public void AddProduct(int quantity)
            {
                this.QuantityInStock += quantity;
            }

            public void BuyProduct(int quantity)
            {
                this.QuantityInStock -= quantity;
            }

            internal string getQuantityInstock()
            {
                throw new NotImplementedException();
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Product lap = new Product(101, "Laptop", 800, 10);
                Console.WriteLine("Product Name: " + lap.getProductName());
                Console.WriteLine("Price: " + lap.getPrice());
                Console.WriteLine("Quantity: " + lap.getQuantityInstock());
            }
        }
    }

}

