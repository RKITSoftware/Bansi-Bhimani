using System;

namespace HierarchicalInheritance
{
    //base class
    class Father
    {
        public void FatherName()
        {
            Console.WriteLine( "My Father Name is Ramesh");
        }
    }
    //Derived class
    class Son : Father
    {
        public void SonName()
        {
            Console.WriteLine("My Name is Rakesh");
        }
    }
    // Derived class
    class Daughter : Father
    {
        public void DaughterName()
        {
            Console.WriteLine("My Name is Ankita");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Son objson = new Son();

            // Displaying Son Name and Father Name for Son
            objson.SonName();
            objson.FatherName();
            
           Daughter objdaughter = new Daughter();

            // Displaying Daughter Name and Father Name for Daughter
            objdaughter.DaughterName();
            objdaughter.FatherName();

            Console.Read();
        }
    }
}
