/*
Exercise:
Write a program where the user enters the names of creative works and their writers, and then the program outputs that information.

Requirements:
Create an interface called IWritable that can be used with classes that represent creative works. The interface should define two methods - GetNameOfWork() and GetWriter().

In the Program class, write a method called PrintWriter() that accepts an IWritable object as input and prints out the name of the work and the writer.

Now, create three classes - Novel, which contains the fields name and author; Movie which contains the fields name and screenwriter; and Song, which contains the fields name and songwriter. Have each class implement the IWritable interface.

In the Main() method, prompt the user to enter the data for a novel, movie, and song, and store the data in those types of objects. Then use the PrintWriter method to print the writer info for each of the objects.

 * 
 */

using System;

namespace Course_Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            string bar = new string('*', 20);
            string name;
            string author; 

            Movie f = new Movie();
            Song s = new Song();

            Console.Write("Enter name of novel: ");
            name = Console.ReadLine();
            Console.Write("Enter name of author: ");
            author = Console.ReadLine();
            Novel b = new Novel(name,author);

            Console.WriteLine();

            Console.Write("Enter name of movie: ");
            f.name = Console.ReadLine();
            Console.Write("Enter name of screenwriter: ");
            f.fieldWriter = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter name of song: ");
            s.name = Console.ReadLine();
            Console.Write("Enter name of songwriter: ");
            s.songWriter = Console.ReadLine();

            Console.WriteLine();
            
            Console.WriteLine(bar);
            Console.WriteLine("LIST OF CREATIVE WORKS");
            PrintWriter(b);
            PrintWriter(f);
            PrintWriter(s);

        }

        static void PrintWriter(IWritable work)
        {

            Console.WriteLine();
            Console.WriteLine($"Name of Work: {work.GetNameOfWork()}");
            Console.WriteLine($"Written By: {work.GetWriter()}");
            Console.WriteLine();
        }
    }
}
