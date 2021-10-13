using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'R', 'K', 'I', 'T' };
            string str1 = new string(charArray);
            Console.WriteLine(str1);
            string str2 = new string('B', 3);
            Console.WriteLine(str2);
            Console.Read();
        }
    }
}
