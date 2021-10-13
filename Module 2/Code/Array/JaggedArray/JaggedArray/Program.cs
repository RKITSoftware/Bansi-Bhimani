using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of jagged array");
            int[][] array1 = new int[3][];
            array1[0] = new int[4] { 54, 78, 92, 56 };
            array1[1] = new int[5] { 15, 80, 16, 20, 27 };
            array1[2] = new int[3] { 38, 90, 12 };
            Console.WriteLine("Length of jagged array is {0}",
           array1.Length);
            Console.WriteLine("\nAccessing 3rd element of 2nd array : {0}",
           array1[1][2]);
            Console.Read();

        }
    }
}
