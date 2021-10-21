using System;
using TestClassLibrary;

namespace use_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra obja = new Algebra();
            int n1 = 30;
            int n2 = 20;
            int result = obja.add(n1, n2);
            Console.WriteLine("{0} + {1} = {2}", n1, n2, result);
            result = obja.sub(n1, n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2, result);
            Console.Read();
        }
    }
}
