using System;

namespace PrivateAM
{
    class Parent
    {
        // Member is declared as private  
        private int value;
        // value is Accessible only inside the class 
        public void setValue(int v)
        {
            value = v;
        }
        public int getValue()
        {
            return value;
        }
    }
    class Child : Parent
    {
        public void showValue()
        {
            // Trying to access value Inside a derived class 
            // Console.WriteLine( "Value = " + value ); 
            // Gives an error 
        }
    }

    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            Parent objp = new Parent();
            // objp.value = 15; 
            // Also gives an error 
            // Use public functions to assign and use value of the member 'value' 
            objp.setValue(24);
            Console.WriteLine("Value = " + objp.getValue());
            Console.Read();

        }
    }
}
