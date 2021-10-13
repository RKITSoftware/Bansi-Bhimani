using System;


namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 6);
            Console.Read();

        }
    }
}
