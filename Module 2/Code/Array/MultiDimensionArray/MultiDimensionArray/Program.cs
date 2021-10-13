using System;

namespace MultiDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of 2D array");
            int[,] array1 = new int[4, 2] { { 51, 20 }, { 43, 46 }, { 85, 61 }, { 87,
80 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }
            Console.Read();
        }
    }
}
