using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise15
{
    class Novel : IWritable
    {
        // Fields
        private string name;
        private string author;
        
        // Properties
        //public string name { get; set;}
        //public string author { get; set; }
        // Constructors
        public Novel(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        // Methods
        public string GetNameOfWork()
        {
            //Console.Write("Enter name of novel: ");
            //name = Console.ReadLine();
            return name;
        }
        public string GetWriter()
        {
            //Console.Write("Enter name of author: ");
            //author = Console.ReadLine();
            return author;
        }
    }
}
