using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            // Adding key/value pairs 
            dict.Add(1, "Welcome");
            dict.Add(2, "to");
            dict.Add(3, "DictionaryDemo Program");
            // Displaying pair of dict by using foreach loop
            foreach (KeyValuePair<int, string> pair in dict)
            {
                Console.WriteLine("{0} and {1}",
                pair.Key, pair.Value);

            }
            Console.WriteLine();
            Console.Read();

        }
    }
}
