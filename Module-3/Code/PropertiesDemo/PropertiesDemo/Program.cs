using System;

namespace PropertiesDemo
{

    public class Student
    {
        // Declare name field
        private string name = "Bansi R. Bhimani";
        // Declare name property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Creating a object of Student
            Student objs = new Student();
            // calls set accessor of the property Name,and pass "Bansi Bhimani" as value of the standard field 'value'.
            objs.Name = "Bansi Bhimani";
            // displays Bansi Bhimani, Calls the get accessor of the property Name.
            Console.WriteLine("Name: " + objs.Name);
            Console.Read();

        }
    }
}
