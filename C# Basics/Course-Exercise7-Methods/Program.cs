/*
Exercise:
Write a program that can sum three integers.

Requirements:
Write a method that accepts three integers as input and returns the sum. Write another method with the same name, that also accepts three integers and adds them together, but for this method, instead of returning data, it also accepts a reference parameter which will be used to store and retrieve the sum.

Prompt the user for three integers, calculate the sum using the first version of the overloaded method, then print the result.

Prompt the user for another three integers and print the sum, but this time, use the second version of the method to perform the calculation.

Output should match the following example:
Enter an integer: 1
Enter a second integer: 2
Enter a third integer: 3
The sum of the three integers is 6

Enter an integer: 2
Enter a second integer: 4
Enter a third integer: 5
The sum of the three integers is 11
 */

using System;

namespace Course_Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum; 

            int[] numArray = new int[3];

            Console.Write("Enter an integer ");
            numArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer ");
            numArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a third integer ");
            numArray[2] = Convert.ToInt32(Console.ReadLine());

            sum = ReturnSum(numArray[0], numArray[1], numArray[2]);

            Console.WriteLine(sum);

            Console.Write("Enter an integer ");
            numArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer ");
            numArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a third integer ");
            numArray[2] = Convert.ToInt32(Console.ReadLine());

            ReturnSum(numArray[0], numArray[1], numArray[2], ref sum);

            Console.WriteLine(sum);

        }

        static int ReturnSum(int x, int y, int z) {

            return x + y + z;

        
        }


        static void ReturnSum(int x, int y, int z, ref int sum) {


            sum = x + y + z;

        }







        //static void Main(string[] args)
        //{
        //    int x;
        //    int y;
        //    int z;
        //    int total;

        //    Console.Write("Enter an integer: ");
        //    x = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter a second integer: ");
        //    y = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter a third integer: ");
        //    z = Convert.ToInt32(Console.ReadLine());
        //    total = SumMethod(x, y, z);

        //    Console.WriteLine("The sum of the three integers is {0}", total);

        //    Console.Write("Enter an integer: ");
        //    x = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter a second integer: ");
        //    y = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter a third integer: ");
        //    z = Convert.ToInt32(Console.ReadLine());

        //    SumMethod(x, y, z, ref total);

        //    Console.WriteLine("The sum of the three integers is {0}", total);


        //    // Others
        //    //SumMethodRef(ref x, ref y, ref z);
        //    //SumMethodOut(out x, out y, out z);

        //}

        //static int SumMethod(int x, int y, int z)
        //{
        //    //int total = 0;

        //    return x + y + z;

        //}

        //static void SumMethod(int x, int y, int z, ref int total)
        //{
        //    //int total = 0;

        //    total = x + y + z;

        //}





        //// Other methods

        //static void SumMethodRef(ref int x, ref int y, ref int z)
        //{
        //    Console.WriteLine();

        //    int total = 0;
        //    total = x + y + z;

        //    Console.WriteLine("The sum of the three integers is {0}", total);
        //}

        //static void SumMethodOut(out int x, out int y, out int z)
        //{
        //    Console.WriteLine();

        //    int total = 0;
        //    // NOTE: OUT Must be initialized from within THIS method block
        //    // if I remove x = Convert.ToInt32(Console.ReadLine());, y = Convert.ToInt32, etc. it will return errors
        //    Console.Write("Enter an integer: ");
        //    x = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter a second integer: ");
        //    y = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter a third integer: ");
        //    z = Convert.ToInt32(Console.ReadLine());
        //    total = x + y + z;

        //    Console.WriteLine("The sum of the three integers is {0}", total);
        //}
    }
}
