using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public abstract class Animals : ISound
    {
        private string name;
        private Gender gender;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }
        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0 || value > 100)
                {
                    throw new IndexOutOfRangeException("Age out of range");
                }
                this.age = value;
            }
        }

        public Animals(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public abstract void Sound();

        public static double AverageAge(Animals[] collection)
        {
            return collection.Average(x => x.Age);
        }
    }
}
