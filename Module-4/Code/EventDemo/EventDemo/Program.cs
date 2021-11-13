using System;

namespace EventDemo
{
    //declare a 'MyDel' delegate 
    public delegate string MyDel(string str);
    class EventProgram
    {
        //declare the 'MyEvent' event of delagate 'MyDel'
        event MyDel MyEvent;
        public EventProgram()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        static void Main(string[] args)
        {
            //creating a object of EventProgram
            EventProgram objeventprogram = new EventProgram();
            string result = objeventprogram.MyEvent("Bansi Bhimani");
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
