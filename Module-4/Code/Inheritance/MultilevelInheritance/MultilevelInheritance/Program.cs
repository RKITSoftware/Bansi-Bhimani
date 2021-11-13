using System;


namespace MultilevelInheritance
{
    class Program
    {
        //base class
        public class Person
        {
            public string persondet()
            {
                return "this is the person class";
            }
        }
        //Derived class
        public class Bird : Person
        {
            public string birddet()
            {
                persondet();
                return "this is the birddet Class";
            }
        }
        //Derived class
        public class Animal : Bird
        {
            public string animaldet()
            {
                persondet();
                birddet();
                return "this is the Animal Class";
            }
        }

        static void Main(string[] args)
        {
            Bird objbird = new Bird();
            // Calling a birddet() and persondet() for Bird
           String a = objbird.birddet();
            String b = objbird.persondet();
            Console.WriteLine(a);
            Console.WriteLine(b);

            Animal objanimal = new Animal();
            // Calling a animaldet() ,birddet() and persondet() for Animal
            String c = objanimal.animaldet();
            String d = objanimal.birddet();
            String e = objanimal.persondet();
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.Read();

        }
    }
}
