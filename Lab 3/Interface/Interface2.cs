using System;

namespace Interface
{
    // Interface for Second Parent Class
    public interface Interface2
    {
        void second();     
    }

    // Second Parent Class
    class StoneCold : Interface2 
    { 
        public void second() 
        { 
            Console.WriteLine("Hell Yeah!!!");
        } 
    } 
}