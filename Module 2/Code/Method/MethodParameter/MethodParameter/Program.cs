using System;

namespace MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method with named parameter");
            string fname = "Bansi";
            string lname = "Bhimani";
            string name = fullName(fname, lname);
            Console.WriteLine("Full name is {0}", name);
            Console.WriteLine("\nMethod with ref parameter");
            string refMethodParemeter = "RKIT Company";
            check(ref refMethodParemeter);
            Console.WriteLine("\nMethod with out parameter");
            int number;
            doubleNum(out number);
            Console.WriteLine("Value of num : {0}", number);
            Console.WriteLine("\nMethod with default parameters");
            studentInfo(fname, lname);
            Console.WriteLine("\nMethod with dynamic parameters");
            dynamicValueMethod(50);
            Console.WriteLine("\nMethod with params ");
            int[] array = { 10, 20, 30, 40, 50 };
            int a = paramMethod(array);
            Console.WriteLine("value returned by paramMethod is {0}", a);
            Console.Read();
        }
        //named parameters
        static string fullName(string s1, string s2)
        {
            return s2 + s1;
        }
        //ref parameters
        static void check(ref string s1)
        {
            if (s1 == "RKIT Company")
                Console.WriteLine("RKIT Company is matched");
            else
                Console.WriteLine("RKIT Comapny is not matched");
        }
        //out parameters
        static void doubleNum(out int num)
        {
            num = 40;
            num *= 2;
        }
        //default parameters
        static void studentInfo(string first, string last, string dept =
       "IT")
        {
            Console.WriteLine("firstname : {0}, lastname : {1}, dept : {2} ", first, last, dept);
        }

        //dynamic parameters
        static void dynamicValueMethod(dynamic val)
        {
            val = val * 5;
            Console.WriteLine("value is {0}", val);
        }
        //params
        static int paramMethod(params int[] number)
        {
            int j = 0;
            foreach (int i in number)
            {
                j = j + i;
            }
            return j;
        }

    }

}
