/*
Exercise:
Write a program that keeps track of the products in a business’s inventory.

Requirements:
Write a Product class that stores the name, price, and quantity of a type of product. The class should be responsible for prompting for input from the user and for displaying a print out of its data. The print out should include the total value that the business owns of that product (its price * quantity).

Write an Inventory class that stores all the products the business owns. The business organizes all of its products into a single inventory, so make this class static. The class should be responsible for displaying a print out of all the products and their info. The print out should include the total value of all products in the inventory.

Follow the principles of encapsulation by making all fields of both classes private.

Create a menu system where the user can enter 1 to add a new product to the inventory, 2 to display the inventory, and 3 to exit the program. User can use the menu repeatedly until they enter 3.
 */

using System;
using System.Collections.Generic;

namespace Course_Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte menuChoice;

            do
            {
                menuChoice = DisplayMenu();

                switch (menuChoice)
                {
                    case 1:
                        Product p = new Product();
                        p.GetNewProduct();
                        Inventory.AddToInventory(p);
                        break;
                    case 2:
                        Inventory.DisplayInventory();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try again.");
                        break;
                }
            } while (menuChoice != 3);
        }

        static byte DisplayMenu()
        {
            byte choice;
            Console.WriteLine("Choose an option from the menu\n1 - Enter Product\n2 - Display Inventory\n3 - Exit");
            Console.Write("\nSelect Option: ");

            choice = Convert.ToByte(Console.ReadLine());

            return choice;
        }
    }
}
