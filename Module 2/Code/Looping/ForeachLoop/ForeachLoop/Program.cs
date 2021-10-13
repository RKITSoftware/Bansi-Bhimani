using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntArray = { 1,9,8,6,45,77};
            foreach (int i in IntArray)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
