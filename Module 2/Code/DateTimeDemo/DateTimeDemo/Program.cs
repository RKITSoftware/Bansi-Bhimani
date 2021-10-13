using System;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructors
            DateTime date1 = new DateTime(2021, 12, 24);
            Console.WriteLine(date1.ToString());
            DateTime date2 = new DateTime(2020, 12, 24, 10, 30, 50);
            Console.WriteLine(date1.ToString());
            Console.WriteLine();
            
            //DateTime Fields
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine();
           
            //DateTime Methods
            Console.WriteLine("DateTime Methods");
            Console.WriteLine();
           
            //Add methods that adds duration
            Console.WriteLine("Add Method");
            System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0);
            System.DateTime newDate1 = DateTime.Now.Add(duration);
            Console.WriteLine(newDate1);
            Console.WriteLine();
           
            // Parsing Method
            string dateString = "Wed Dec 29, 2021";
            DateTime dateTime12 = DateTime.Parse(dateString);
            Console.WriteLine(dateTime12);
            Console.WriteLine();
            
            // Date Difference Method
            System.DateTime date3 = new System.DateTime(2021, 3, 10, 2, 15, 10);
            System.DateTime date4 = new System.DateTime(2021, 7, 15, 6, 30, 20);

            System.TimeSpan diff1 = date4.Subtract(date2);
            Console.WriteLine(diff1.ToString());
            Console.WriteLine();
            
            //Universal time
            DateTime dateObj = new DateTime(2021, 12, 20, 10, 20, 30);
            Console.WriteLine("universal time : " + dateObj.ToUniversalTime());
            
            //DateTime properties
            Console.WriteLine("\nDateTime Properties are used as follows");
            DateTime myDate = new DateTime(2021, 12, 24, 10, 30, 45);
            int year = myDate.Year;
            Console.WriteLine("year - {0}", year);
            int month = myDate.Month;
            Console.WriteLine("month - {0}", month);
            int day = myDate.Day;
            Console.WriteLine("day - {0}", day);
            int hour = myDate.Hour;
            Console.WriteLine("Hour - {0}", hour);
            int minute = myDate.Minute;
            Console.WriteLine("minute - {0}", minute);
            int second = myDate.Second;
            Console.WriteLine("second - {0}", second);
            int weekDay = (int)myDate.DayOfWeek;
            Console.WriteLine("day of week - {0}", weekDay);
            Console.Read();

        }
    }
}
