using System;
using System.Collections;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Stack
            Stack myStack = new Stack();

            // Inserting the elements into the Stack
            myStack.Push("Chandigarh");
            myStack.Push("Delhi");
            myStack.Push("Gujarat");
            myStack.Push("Rajsthan");
            myStack.Push("Punjab");
            myStack.Push("Mumbai");

            // Displaying the count of elements contained in the Stack
            Console.Write("Total number of elements in the Stack are : ");
            Console.WriteLine(myStack.Count);

            // Checking whether the element is present in the Stack or not
            // The function returns True if the element is present in the Stack, else returns False
            Console.WriteLine(myStack.Contains("Gujarat"));
            Console.Read();
        }
    }
}
