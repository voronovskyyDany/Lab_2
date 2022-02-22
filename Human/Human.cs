using System;
using System.Collections.Generic;
using System.Text;

namespace LAB
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public abstract void Work();
        public abstract void Relax();
    }
}
