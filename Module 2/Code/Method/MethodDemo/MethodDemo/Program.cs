using System;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int l = 15;
            int b = 6;
            int area = r.Area(l, b);
            Console.WriteLine("Area of rectangle with length {0} and breadth {1} = {2} ", l,b,area);
            Console.Read();
        }
    }
    class Rectangle
    {
        public int Area(int length, int breadth)
        {
            int ans = length * breadth;
            return ans;
        }
    }
    
}
