using System;

namespace MultipleInheritance
{
    public interface IA //ineterface 1 
    {
        string setImgs(string a);
    }
    public interface IB //Interface 2 
    {
        int getAmount(int Amt);
    }
    public class ICar : IA, IB //implementatin 
    {
        public int getAmount(int Amt)
        {
            return 10;
        }
        public string setImgs(string a)
        {
            return "this is the car";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICar objicar = new ICar();
            int a = objicar.getAmount(10);
            Console.WriteLine(a);
            String b = objicar.setImgs("ic object");
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
