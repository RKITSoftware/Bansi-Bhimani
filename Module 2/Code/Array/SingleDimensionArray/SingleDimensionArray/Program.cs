using System;

namespace SingleDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of 1D Array");
            int[] array1 = { 1, 57, 73, 26, 28, 50 };
            Array.Sort(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.Read();

        }
    }
}
