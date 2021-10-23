using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary using Dictionary<TKey,TValue> class
            Dictionary<int, string> My_dict = new Dictionary<int, string>();
            // Adding key/value pairs 
            My_dict.Add(1, "Welcome");
            My_dict.Add(2, "to");
            My_dict.Add(3, "DictionaryDemo Program");
            // Displaying pair of dict by using foreach loop
            foreach (KeyValuePair<int, string> pair in My_dict)
            {
                Console.WriteLine("{0} and {1}",
                pair.Key, pair.Value);

            }
            Console.WriteLine();
            // Using ContainsKey() method to check the specified key is present or not
            if (My_dict.ContainsKey(1) == true)
            {
                Console.WriteLine("Key is found...!!");
            }

            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            // Using ContainsValue() method to check the specified value is present or not
            if (My_dict.ContainsValue("Welcome") == true)
            {
                Console.WriteLine("Value is found...!!");
            }

            else
            {
                Console.WriteLine("Value is not found...!!");
              
            }
            Console.Read();
        }
    }
}
