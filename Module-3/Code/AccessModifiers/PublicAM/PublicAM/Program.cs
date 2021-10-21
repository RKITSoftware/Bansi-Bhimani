using System;

namespace PublicAM
{
    // Declaring members rollNo and name as public
    class Student
    {
        public int rollNo;
        public string name;
        //constructor
        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }
        // method getName also declared as public
        public string getName()
        {
            return name;
        }
    }

    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            // Creating object of the class Student
            Student objs = new Student(152, "Bansi");
            // Displaying details directly using the class members accessible through another method
            Console.WriteLine("Roll number: {0}", objs.rollNo);
            Console.WriteLine("Name: {0}", objs.name);
            Console.WriteLine();
            // Displaying details using member method also public
            Console.WriteLine("Name: {0}", objs.getName());
            Console.Read();

        }
    }
}
