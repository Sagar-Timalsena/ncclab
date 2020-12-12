using System;

delegate void Example(string s);

namespace Delegate
{ 
    class Program
    {
        public static void Result(string str) 
        {
            Console.WriteLine("Thats the bottom line cause '{0}' said so.", str);
        }

        static void Main(string[] args) 
        {
            // Creating Delegate object
            Example eg = new Example(Result);
                
            // Calling the methods using the delegate object
            eg("Sagar Timalsena");
        }
    }
}



