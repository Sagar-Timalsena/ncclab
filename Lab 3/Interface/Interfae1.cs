
using System; 

namespace Interface
{
    // Interface for First Parent Class
    public interface Interface1
    {
         void first();
    }

    // First Parent Class
    public class TheRock : Interface1 
     { 
        public void first() 
        { 
            Console.WriteLine("It doesnot matter what your name is.");
        } 
    } 
}