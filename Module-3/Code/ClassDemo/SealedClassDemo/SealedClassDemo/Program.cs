using System;

namespace SealedClassDemo
{
    //Creating a sealed class
    public sealed class Employee
    {
        string fName;
        string lName;
    }
    //Inheriting the Sealed Class
    class Program : Employee
    {
        static void Main(string[] args)
        {
        }
    }
}
