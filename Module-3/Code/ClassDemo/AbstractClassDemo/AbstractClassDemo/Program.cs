using System;

namespace AbstractClassDemo
{
    //declare class 'AreaClass' as abstract
    abstract class AreaClass
    {
       // declare method 'Area' as abstract
        abstract public int Area();
    }
    // class 'AreaClass' inherit in child class 'Square'
    class Square : AreaClass
    {
        int side = 0;
        // constructor 
        public Square(int n)
        {
            side = n;
        }
        // the abstract method 'Area' is overridden here 
        public override int Area()
        {
            return side * side;
        }
    }

    class Program
    {
        // Main method
        static void Main(string[] args)
        {
            Square objs = new Square(7);
            Console.WriteLine("Area = " + objs.Area());
            Console.Read();

        }
    }
}
