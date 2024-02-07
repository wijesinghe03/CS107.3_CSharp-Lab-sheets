using System;

namespace Lab2Q4
{
    class Product
    {
        // Properties
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        // Parameterized Constructor
        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: $" + Price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate object using the constructor
            Product product1 = new Product("Smart Phone", 350m);

            // Display the product details
            product1.DisplayProductDetails();

            Console.ReadLine();
        }
    }
}