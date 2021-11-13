﻿using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 19, 0, 55, 59 };

            try
            {

                // Try to generate an exception
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            // Catch block for invalid array access
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Finally block
            // Will execute irrespective of the above catch blocks
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
            }
            Console.Read();
        }
    }
}
