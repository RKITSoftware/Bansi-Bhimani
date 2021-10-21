using System;
using System.Collections;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Queue 
            Queue myQueue = new Queue();
            // Inserting the elements into the Queue 
            myQueue.Enqueue("ab");
            myQueue.Enqueue("cd");
            myQueue.Enqueue("ef");
            myQueue.Enqueue("gh");
            myQueue.Enqueue("ij");
            // Displaying the count of elements 
            // contained in the Queue 
            Console.Write("Total number of elements present in the Queue are: ");
            Console.WriteLine(myQueue.Count);
            // Displaying the beginning element of Queue 
            Console.WriteLine("Beginning Item is: " + myQueue.Peek());
            Console.Read();
        }
    }
}
