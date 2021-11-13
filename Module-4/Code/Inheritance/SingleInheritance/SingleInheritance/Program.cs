using System;

namespace SingleInheritance
{
    //Base class
    class Shape
    {
        public int width;
        public int height;
        public void setWidth(int w)
        {
           width = w;
        }
        public void setHeight(int h)
        {
           height = h;
        }
        
    }
    // Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle objrectangle = new Rectangle();
            objrectangle.setWidth(10);
            objrectangle.setHeight(10);
            // Print the area of the object.
            Console.WriteLine("Area of Rectangle is: {0}", objrectangle.getArea());
            Console.Read();

        }
    }
}
