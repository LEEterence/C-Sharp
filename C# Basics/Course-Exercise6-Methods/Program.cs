/*
Exercise:
Write a program that can tell you if a number is a prime number.

Requirements:
Write a method that accepts an integer as input and outputs true if that integer is a prime number and false if it is not. A prime number is an integer greater than 1 that is only evenly divisible by 1 and itself. Hint: use the modulus operator % which divides two numbers and returns the remainder.

Prompt the user to enter an integer. User can enter the number 1 to exit the program. Pass the integer to the method you wrote and let the user know if the number is prime or not. Let the user enter as many integers as they want until they enter 1 to exit the program.

Output should match the following example:

Enter an integer (1 to exit): 2
2 is a prime number
Enter an integer (1 to exit): 3
3 is a prime number
Enter an integer (1 to exit): 4
4 is not a prime number
Enter an integer (1 to exit): 5
5 is a prime number
Enter an integer (1 to exit): 6
6 is not a prime number
Enter an integer (1 to exit): 7
7 is a prime number
Enter an integer (1 to exit): 1
 */

using System;

namespace Course_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            bool exitFlag = false;

            do
            {
                Console.Write("Enter an integer (1 to exit):");
                x = Convert.ToInt32(Console.ReadLine());
                
                if (x == 1)
                {
                    exitFlag = true;
                }
                else
                {
                    //ReadPrime(x);
                    if (ReadPrime(x))
                    {
                        Console.WriteLine("{0} is a prime number", x);
                    }
                    else
                    {
                        Console.WriteLine("{0} is NOT a prime number", x);
                    }
                }
            } while (exitFlag == false) ;
        }

        static bool ReadPrime(int x)
        {
            bool isPrime = true;

            for(int i = 2; i < x; i++)
            {
                if(x % i == 0)
                {
                    isPrime = false;
                    break;              // break out of the loop to avoid unnecessary wait time
                }
            }

            return isPrime;
            //if(isPrime == true)
            //{
            //    Console.WriteLine("{0} is a prime number",x);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is NOT a prime number",x);
            //}
        }
    }
}
