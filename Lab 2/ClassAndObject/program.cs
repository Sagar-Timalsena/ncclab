using System;

namespace ClassAndObject
{
    public class Testing
    {
        public void Checking()
        {
           Console.WriteLine("Hello Sagar Timalsena");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Testing Check123 = new Testing();
            Check123.Checking();
        }
    }
}