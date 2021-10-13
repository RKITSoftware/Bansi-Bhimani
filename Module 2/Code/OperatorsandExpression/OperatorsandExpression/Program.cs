using System;

namespace OperatorsandExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //incremental operator
            Console.WriteLine("Incremental operator:");
            int i = 3;
            Console.WriteLine("(initially i=3)i++ = {0}", i++);
            Console.WriteLine("After i++, i = {0}", i);
            //Binary Arithmetic operators
            Console.WriteLine("\nBinary arithmetic operator:");
            int a = 5, b = 8, c;
            Console.WriteLine("Operations on a = 5 and b = 8");
            c = a + b;
            Console.WriteLine("a + b = {0}", c);
            c = b - a;
            Console.WriteLine("b - a = {0}", c);
            c = a * b;
            Console.WriteLine("a*b = {0}", c);
            //logical operators
            Console.WriteLine("\nLogical operator:");
            bool p = true & false;
            Console.WriteLine("for expression bool p = true & false, p={0}",
           p);
            bool q = true | true;
            Console.WriteLine("for expression q = true | true, q={0}", q);
            //comparison operators
            Console.WriteLine("\nComparison operator:");
            int x = 8, y = 10;
            Console.WriteLine("For x = 8 and y = 10");
            if (x > y)
                Console.WriteLine("x > y");
            else if (x < y)
                Console.WriteLine("x < y");
            else
                Console.WriteLine("x = y");
            //Assignment operators 
            Console.WriteLine("\nAssignment operator:");
            int assign = 9;
            Console.WriteLine("assign = {0}", assign);
            assign += 4;
            Console.WriteLine("(after performing assign+=4) assign = {0}",
           assign);
            //Ternary operator
            Console.WriteLine("\nTernary operator:");
            int t1 = 5, t2 = 128;
            var m = t1 > t2 ? "t1>t2" : "t1<t2";
            Console.WriteLine(" m = {0}", m);
            //Expressions example
            Console.WriteLine("\nExpression:");
            int k = 1, l = 7, v= 3;
            int j = k * l - v; // expression
            Console.WriteLine("Here k*l-v is an expression");
            Console.Read();
        }
    }
}
