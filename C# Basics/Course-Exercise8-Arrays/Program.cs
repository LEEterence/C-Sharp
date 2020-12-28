/*
Exercise:
Write a program that can store a list of grocery items and search the list.

Requirements:
Use an array to store a list of five grocery items. Prompt the user to enter the five items. Then prompt the user to enter a substring to search for within the elements of the array. Tell the user how many elements contain the specified substring.

Use string interpolation when combining variables with string literals.

Output should match the following examples.

Example 1:
Enter grocery item 1: red apples
Enter grocery item 2: bananas
Enter grocery item 3: green apples
Enter grocery item 4: peas
Enter grocery item 5: carrots

Enter a substring to search for: apples

There are 2 elements that contain the substring "apples"

Example 2:
Enter grocery item 1: red apples
Enter grocery item 2: bananas
Enter grocery item 3: green apples
Enter grocery item 4: peas
Enter grocery item 5: carrots

Enter a substring to search for: bananas

There is 1 element that contains the substring "bananas"
 */

using System;

namespace Course_Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            string[] groceryArray = new string[5];
            string item;
            string search;
            int count = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Enter a grocery item {i+1}: ");
                groceryArray[i] += Console.ReadLine();
            }
            Console.Write("Enter a substring to search for: ");
            search = Console.ReadLine();

            foreach(string grocery in groceryArray)
            {
                if (grocery.Contains(search))
                {
                    count++;
                }
            }
            if(count > 1)
            {
                Console.WriteLine($"There are {count} elements that contains the substring \"{search}\"");
            }
            else if(count == 1){
                Console.WriteLine($"There is {count} element that contains the substring \"{search}\"");
            }
            else
            {
                Console.WriteLine($"There are no elements that contains the substring \"{search}\"");
            }
        }
    }
}
