using System;

namespace StaticClassDemo
{
        //Creating static class Using static keyword
        static class Student
        {
            // Static data members of Student
            public static string f_name = "Bansi";
            public static string l_name = "Bhimani";
            public static int roll_no = 18;
            // Static method of Student 
            public static void details()
            {
                Console.WriteLine("The details of Student is:");
            }
        }
    class Program
    {
        // main method
        static void Main(string[] args)
        {
            // Calling static method of student
            Student.details();
            //Accessing the static data members of student
            Console.WriteLine("first name : {0} ", Student.f_name);
            Console.WriteLine("last name : {0} ", Student.l_name);
            Console.WriteLine("roll no : {0} ", Student.roll_no);
            Console.Read();

        }
    }
}
