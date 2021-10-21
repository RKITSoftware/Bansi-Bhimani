using System;

namespace ProtectedAM
{
    class X
    {
        // Member x declared as protected
        protected int x;
        public X()
        {
            x = 100;
        }
    }
    // class Y inherits the class X
    class Y : X
    {
        // Members of Y can access 'x'
        public int getX()
        {
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();
            // Displaying the value of x
            Console.WriteLine("Value of x is : {0}", obj2.getX());
            Console.Read();
        }
    }
}
