using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise10
{
    class Product
    {
        //Fields
        private string productName;
        private double productPrice;
        private int productQuantity;
        
        // Constructors

        
        // Methods
        public void GetNewProduct()
        {
            Console.Write("Enter product name: ");
            productName = Console.ReadLine();
            Console.Write("Enter price: ");
            productPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity: ");
            productQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nProduct added to Inventory\n");
        }
        public void DisplayProductInfo()
        {
            double totalPrice;

            totalPrice = MultiplyPriceQuantity();

            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Price: ${productPrice:N2}");
            Console.WriteLine($"Quantity: {productQuantity}");
            Console.WriteLine($"Total Value: ${totalPrice:N2}");
            Console.WriteLine();
        }

        public double MultiplyPriceQuantity()
        {
            return productPrice * productQuantity;
        }

        //Methods
        //public string NewProductName()
        //{
        //    Console.Write("Enter product name: ");
        //    productName = Console.ReadLine();
        //    return productName;
        //}
        //public double NewProductPrice()
        //{
        //    Console.Write("Enter price: ");
        //    productPrice = Convert.ToDouble(Console.ReadLine());
        //    return productPrice;
        //}
        //public int NewProductQuantity()
        //{
        //    Console.Write("Enter quantity: ");
        //    productQuantity = Convert.ToInt32(Console.ReadLine());
        //    return productQuantity;
        //}
    }
}
