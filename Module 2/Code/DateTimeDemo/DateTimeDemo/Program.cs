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
            Console.WriteLine(date2.ToString());
            Console.WriteLine();
            
            //DateTime Fields
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine();
           
           
            //Add methods that adds days
            Console.WriteLine("Add Method");
            Console.WriteLine("Old Date:" + date1.ToString());
            DateTime dt1 = date1.AddDays(7); 
            Console.WriteLine("New Date:" + dt1.ToString());
            Console.WriteLine();
           
            
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
