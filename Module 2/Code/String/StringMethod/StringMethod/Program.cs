using System;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //clone method
            Console.WriteLine("Demonstration of clone method");
            String a = "Hello";
            String b = (String)a.Clone();
            Console.WriteLine(b);

            //Concat method
            Console.WriteLine("\nDemonstration of Concate method");
            String c = "World";
            Console.WriteLine(string.Concat(a, c));

            //Contains method
            Console.WriteLine("\nDemonstration of Contains method");
            String d = "Hello World";
            bool e = d.Contains(c);
            if (e)
                Console.WriteLine("d contains c");
            else
                Console.WriteLine("d does not contains c");

            //Copy method 
            Console.WriteLine("\nDemonstration of Copy method");
            String f = string.Copy(d);
            Console.WriteLine(d);
            
            //Equals method
            Console.WriteLine("\nDemonstration of Equals method");
            Console.WriteLine(a.Equals(c));
            
            //IndexOf method
            Console.WriteLine("\nDemonstration of IndexOf method");
            int g = a.IndexOf('e');
            Console.WriteLine(g);
            
            //Insert method
            Console.WriteLine("\nDemonstration of Insert method");
            String h = a.Insert(2, c);
            Console.WriteLine(h);
            
            //Replace method
            Console.WriteLine("\nDemonstration of Replace method");
            string i = a.Replace("He", "Hee");
            Console.WriteLine(i);
           
            //Substring method
            Console.WriteLine("\nDemonstration of Substring method");
            string j = a.Substring(2);
            Console.WriteLine(j);
            
            //Trim method
            Console.WriteLine("\nDemonstration of Trim method");
            string k = " Miracle Accounting Software ";
            Console.WriteLine(k);
            Console.Read();

        }
    }
}
