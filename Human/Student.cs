using System;
using System.Collections.Generic;
using System.Text;

namespace LAB
{
    class Student : Learner
    {
        public int Stipend { get; set; }
        public string Group { get; set; }

        public Student(string firstName, string lastName, int age, string id, bool isWorking, List<string> listOfSubjects, int stipend, string group)
            :base(firstName, lastName, age, id, isWorking, listOfSubjects)
        {
            Stipend = stipend;
            Group = group;
        }
        
        public override void Study()
        {
            Console.WriteLine("Student study");
        }
        public override void Relax()
        {
            Console.WriteLine("Student relax");
        }
        public override void Work()
        {
            Console.WriteLine("Student doesn`t work. He(She) is studing");
        }
    }
}
