using System;

namespace OverrideAndOverload
{
    public class Base
    {
        public string Name; 

        public Base()
        {
            Console.WriteLine("Welcome Everyone.");
        }

        public Base(string name)
        {
            Name = name;
            Console.WriteLine("Welcome {0}, to base class.",Name);
        }

        public virtual void display()
        {
            Console.WriteLine("This is base class.");
        }
    }
}
