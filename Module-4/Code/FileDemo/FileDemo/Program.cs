using System;
using System.IO;


namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string s = @"D:\Company_RKIT\Module-4\Code\FileDemo\Source\Test.txt";
            string d = @"D:\Company_RKIT\Module-4\Code\FileDemo\Destination\Test.txt";
            
            //copy and delete operation in file
            try
            {
                File.Copy(s,d, true);
                Console.WriteLine("File copied from Source to Destination...");
                File.Delete(s);
                Console.WriteLine("File deleted from Source...");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found exception - {0} , occured ", e.StackTrace);
            }

            //move operation in file
            try
            {
                File.Move(d, s);
                Console.WriteLine("File moved from Destination to Source again...");
            }
            catch (Exception) { }
            FileStream objfilestream = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i < 10; i++)
            {
                objfilestream.WriteByte((byte)i);
            }
            objfilestream.Position = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(objfilestream.ReadByte() + " ");
            }
            objfilestream.Close();

            
                Console.Read();

        }
    }
}
