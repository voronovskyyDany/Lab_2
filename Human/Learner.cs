using System;
using System.Collections.Generic;
using System.Text;

namespace LAB
{
     abstract class Learner : Human
    {
        public string Id { get; set; }
        public bool IsWorking { get; set; }
        public List<string> ListOfSubjects { get; set; }
        public Learner(string firstName, string lastName, int age, string id, bool isWorking, List<string> listOfSubjects)
            : base(firstName, lastName, age)
        {
            Id = id;
            IsWorking = isWorking;
            ListOfSubjects = listOfSubjects;
        }
        public abstract void Study();
    }
}
