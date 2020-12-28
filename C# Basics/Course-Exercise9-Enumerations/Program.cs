/*
 *Exercise:
Write a program that can store a list of directions and then print out the list as a series of symbols.

Requirements:
Create an enumeration that can be used to hold one of the four ordinal directions (north, south, east, and west). Allow the user to input a series of these directions and store them in a List object. Do not allow them to enter invalid input. When they are finished entering values, let them know how many values they entered, and then print out the list as a series of arrows (using the ^ v > < characters).

Output should match the following example:

Enter the next direction (n/s/e/w or 0 to finish): n
Enter the next direction (n/s/e/w or 0 to finish): n
Enter the next direction (n/s/e/w or 0 to finish): q
Invalid input
Enter the next direction (n/s/e/w or 0 to finish): e
Enter the next direction (n/s/e/w or 0 to finish): e
Enter the next direction (n/s/e/w or 0 to finish): w
Enter the next direction (n/s/e/w or 0 to finish): s
Enter the next direction (n/s/e/w or 0 to finish): 0

You entered 6 directions. The directions are as follows:
^ ^ > > < v
 */

using System;
using System.Collections.Generic;

namespace Course_Exercise9
{

    class Program
    {
        enum direction { North = '^', West = '<', South = 'v', East = '>'}
        static void Main(string[] args)
        {
            List<direction> directionList = new List<direction>();
            bool flag = false;
            char value;
            
            do
            {
                Console.Write("Enter the next direction (n/s/e/w or 0 to finish): ");
                value = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (value == '0')
                {
                    flag = true;
                }
                else
                {
                    switch (value)
                    {
                        case 'n':
                            //directionList.Add('^');
                            directionList.Add(direction.North);
                            break;
                        case 's':
                            //directionList.Add('v');
                            directionList.Add(direction.South);
                            break;
                        case 'w':
                            directionList.Add(direction.West);
                            //directionList.Add('>');
                            break;
                        case 'e':
                            directionList.Add(direction.East);
                            //directionList.Add('<');
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            } while (flag == false);

            Console.WriteLine($"You entered {directionList.Count} directions.The directions are as follows: ");
            foreach (char x in directionList)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine();
        }
    }
}
