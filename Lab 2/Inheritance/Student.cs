using System;

namespace Inheritance
{
    public class Student
    {
        string name; 
        int rollNo;

        public void addStudent(string Name, int RollNo)
        {
            name = Name;
            rollNo = RollNo;
        }

        public void personalDetail()
        {
            Console.WriteLine("Hello, this is {0} and my roll no. is {1}", name, rollNo);
        }
    }
}

