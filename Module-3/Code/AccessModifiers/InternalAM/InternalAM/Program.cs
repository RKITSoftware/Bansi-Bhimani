using System;

namespace InternalAM
{
    // Declare class Complex as internal
    internal class Complex
    {
        int real;
        int img;
        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }
        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }

    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            // Instantiate the class Complex in separate class but within the same assembly
            Complex objc = new Complex();
            // Accessible in class Program
            objc.setData(1, 2);
            objc.displayData();
            Console.Read();

        }
    }
}
