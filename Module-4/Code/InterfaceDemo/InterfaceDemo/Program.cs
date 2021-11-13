using System;

namespace InterfaceDemo
{
    // A simple interface
    interface inter
    {
        // method having only declaration 
        // not definition
        void display();
    }

    // A class that implements interface.
    class Program : inter
    {
        // providing the body part of function
    public void display()
        {
            Console.WriteLine("Hello World!");
        }

        // Main Method
        static void Main(string[] args)
        {
            // Creating object
            Program objprogram = new Program();

            // calling method
            objprogram.display();
            Console.Read();
        }
    }
}
