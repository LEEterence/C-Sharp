/*
Exercise:
Write a program that can store objects in a Queue.

Requirements:
Write your own Queue class called SnazzyQueue. A Queue is a collection class, similar to a Stack in that when you read an item, it removes it from the collection. Unlike a Stack, however, a Queue reads its data on a first-in, first-out (FIFO) basis. So the first item added to the queue will be the first item read from the queue. Hint: Use a List field to store the items.

Use generics so that SnazzyQueue will be able to store any data type that you specify.

In Main(), create an instance of SnazzyQueue that can store integers. Allow the user to either add an item to the queue (enqueue) or read and remove an item from the queue (dequeue).

 */

using System;

namespace Course_Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            SnazzyQueue<int> queue = new SnazzyQueue<int>();
            byte menuChoice;
            int num;

            do
            {
                DisplayMenu();
                menuChoice = Convert.ToByte(Console.ReadLine());
                try
                {
                    switch (menuChoice)
                    {
                        case 1:
                            Console.Write("Enter an item to enqueue: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            queue.Enqueue(num);
                            //Console.WriteLine($"\n{num} has been added to the queue\n");

                            break;
                        case 2:
                            num = queue.Dequeue();
                            //num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\n{num} has been removed from the queue\n");
                            break;
                        case 3:
                            Console.WriteLine($"Items in the queue: ");
                            queue.ListQueue();
                            break;
                        case 4:
                            break;
                        default:
                            throw new Exception("Select must be between 1 - 4. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (menuChoice != 4);

        }

        static void DisplayMenu()
        {
            Console.WriteLine("1 - Enqueue\n2 - Dequeue\n3 - List Queue\n4 - Exit");
            Console.Write("Enter Selection: ");
        }
    }
}
