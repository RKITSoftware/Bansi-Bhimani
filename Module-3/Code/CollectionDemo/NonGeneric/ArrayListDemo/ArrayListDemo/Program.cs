using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an ArrayList 
            ArrayList myList = new ArrayList();

            // Adding elements to ArrayList 
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            // Displaying count of elements of ArrayList 
            Console.WriteLine("Number of elements: " + myList.Count);

            // Displaying Current capacity of ArrayList 
            Console.WriteLine("Current capacity: " + myList.Capacity);

            // Remove the 3 element from the ArrayList Using Remove() method
            myList.Remove(3);
            Console.WriteLine("After Remove() method the " + "number of elements: " + myList.Count);

            Console.Read();
        }
    }
}
