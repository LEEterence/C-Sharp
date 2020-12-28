/**
 * Don't need a list for each data type - instead create a new Product object with each new iteration that holds the properties of name, price and quantity. 
 * As a result - only one list is required. A product object is created each time 1 in the menu choice is created and added to the static (global) products list in this class.
 * Since there is ONLY ONE inventory we set it and everything inside as static.
 * 
 */
    

///

using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise10
{
    static class Inventory
    {
        static private List<Product> products;

        static Inventory()
        {
            products = new List<Product>();
        }

        static public void AddToInventory(Product item)
        {
            products.Add(item);
        }

        static public void DisplayMenu()
        {
            Console.WriteLine("Current Inventory: ");
            string result = new string('*', 20);
            Console.WriteLine();
        }

        static public void DisplayInventory()
        {
            double inventoryValue = 0;
            DisplayMenu();

            foreach (Product item in products)
            {
                item.DisplayProductInfo();
                inventoryValue +=  item.MultiplyPriceQuantity();
            }

            Console.WriteLine($"Total Inventory value: ${inventoryValue.ToString("F")}\n");
        }

        //static public void DisplayProducts()
        //{
        //    double inventoryValue = 0;
        //    for (int i = 0; i < nameList.Count; i++)
        //    {
        //        totalPrice += MultiplyPriceQuantity(priceList[i],quantityList[i]);

        //        Console.WriteLine($"Product Name: {nameList[i]}");
        //        Console.WriteLine($"Price: ${priceList[i]:N2}");
        //        Console.WriteLine($"Quantity: {quantityList[i]}");
        //        Console.WriteLine($"Total Value: ${totalPrice:N2}");
        //        Console.WriteLine();

        //        inventoryValue += totalPrice;
        //    }
        //    Console.WriteLine($"Total inventory value: ${inventoryValue:N2} \n");
        //}

        //static private double MultiplyPriceQuantity(double x, int y)
        //{
        //    return x*y;
        //}
        //static public void AddProductName(string productName)
        //{
        //    nameList.Add(productName);
        //}
        //static public void AddProductPrice(double productPrice)
        //{
        //    priceList.Add(productPrice);
        //}
        //static public void AddProductQuantity(int productQuantity)
        //{
        //    quantityList.Add(productQuantity);
        //}
    }
}
