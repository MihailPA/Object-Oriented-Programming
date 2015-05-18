using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LaststName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2} years old", this.firstName, this.lastName, this.age);
        }


    }
}
