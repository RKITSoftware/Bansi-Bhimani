using System;

namespace ProtectedInternalAM
{
    public class Parent
    {
        // Declaring member as protected internal 
        protected internal int value;
    }

    class Program : Parent
    {
        static void Main(string[] args)
        {
            // Accessing value in another assembly
            Program objp = new Program();
            // Member value is Accessible 
            objp.value = 100;
            Console.WriteLine("Value = " + objp.value);
            Console.Read();

        }
    }
}
