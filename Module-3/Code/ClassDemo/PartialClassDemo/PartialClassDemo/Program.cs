using System;

namespace PartialClassDemo
{
    public partial class Student
    {
        //'FullName' declared in first partial class
        public void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName);
        }
    }
    public partial class Student
    {
        //'FirstName' and 'LastName' are declared in another partial class
        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Student objs = new Student();
                // Accesing data member
                objs.FirstName = "Viren";
                objs.LastName = "Goenka";
                // Calling a method
                objs.FullName();
                Console.ReadLine();
            }
        }
 }
