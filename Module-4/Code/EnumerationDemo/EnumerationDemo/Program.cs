using System;

namespace EnumerationDemo
{
    // making an enumerator 'month'
    enum Months
    {
        // following are the data members
        January, February, March, April, May, June, July,
        August, September, October, November, December
    };
    class Program
    {
        static void Main(string[] args)
        {   
            // getting the integer values of data members..
            int month1 = (int)Months.May;
            int month2 = (int)Months.January;
            Console.WriteLine("May: {0}", month1);
            Console.WriteLine("January: {0}", month2);
            Console.Read();

        }
    }
}
