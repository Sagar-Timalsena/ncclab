using System;

namespace OverrideAndOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default Constructor
            Base b1 = new Base();

            // Constructor Overloading
            Base b2 = new Base("Sagar");   

            b1.display();

            Derived d1 = new Derived();
            
            // Function Overriding
            d1.display();          

            // Function Overloading
            d1.display("Sagar");       
        }
    }
}
