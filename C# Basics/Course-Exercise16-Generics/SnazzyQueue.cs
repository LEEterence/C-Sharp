//Write your own Queue class called SnazzyQueue. A Queue is a collection class, similar to a Stack in that when you read an item, it removes it from the collection. Unlike a Stack, however, a Queue reads its data on a first-in, first-out (FIFO) basis. So the first item added to the queue will be the first item read from the queue. Hint: Use a List field to store the items.

using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise16
{
    class SnazzyQueue<T>
    {
        // Fields
        private List<T> snazzyList;
        //private int currentIndex;
        //private int initialIndex;

        // Properties


        // Constructors
        public SnazzyQueue()
        {
            snazzyList = new List<T>();
            //currentIndex = 0;
            //initialIndex = 0;
        }

        // Methods
        public void Enqueue(T queued)
        {
            snazzyList.Add(queued);
            Console.WriteLine($"\n{queued} has been added to the queue\n");
            //currentIndex++;
        }

        public T Dequeue()
        {
            T dq;

            dq = snazzyList[0];
            snazzyList.RemoveAt(0);
            //initialIndex++;
           
            return dq;
        }

        public void ListQueue()
        {
            foreach(T queue in snazzyList)
            {
                Console.WriteLine(queue);
            }
        }
    }
}
