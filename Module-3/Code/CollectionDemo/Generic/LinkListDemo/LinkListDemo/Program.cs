using System;
using System.Collections.Generic;

namespace LinkListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a linkedlist Using LinkedList class
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the Linkedlist Using AddLast() method
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");

            // Accessing the elements of  LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // Check if the given element is available or not
            if (my_list.Contains("Shilpa") == true)
            {
                Console.WriteLine("Element Found...!!");
            }
            else
            {
                Console.WriteLine("Element Not found...!!");
            }

            Console.Read();
        }
    }
}
