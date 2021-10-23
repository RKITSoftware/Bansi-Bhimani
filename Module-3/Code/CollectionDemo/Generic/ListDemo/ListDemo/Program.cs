using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a List of integers 
            List<int> mylist = new List<int>();
            // adding items in mylist 
            for (int j = 1; j < 6; j++)
            {
                mylist.Add((j * 2));
            }
            // Displaying items of mylist by using foreach loop 
            foreach (int items in mylist)
            {
                Console.WriteLine(items);
            }
            // Checking whether 4 is present in List or not
            Console.Write(mylist.Contains(4));
            Console.Read();

        }
    }
}
