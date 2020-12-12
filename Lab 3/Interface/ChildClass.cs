using System;

namespace Interface
{
    // Multiple Inheritance through Interface1 and Interface2
    class ChildClass : Interface1, Interface2
    { 
        TheRock obj1 = new TheRock(); 
        StoneCold obj2 = new StoneCold(); 
        public void first() 
        {
            Console.Write("What is your name: ");
            Console.ReadLine();
            obj1.first();
        } 
        public void second() 
        {
            Console.WriteLine("\nIf you like it, give me a Hell Yeah!!!");
            obj2.second(); 
        } 
    }
}
