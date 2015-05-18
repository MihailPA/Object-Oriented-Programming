using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Student : Human
    {
        public int Grade { get; set; }

        public override string Firstname { get; set; }

        public override string Lastname { get; set; }

        public Student(string inputFName, string inputLName, int inputGrade)
            : base(inputFName, inputLName)
        {
            this.Grade = inputGrade;
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname + " -> " + "Grade: " + this.Grade ;
        }
    }
}
