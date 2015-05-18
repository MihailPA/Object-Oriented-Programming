﻿//Problem 2. Students and workers
//Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
     public abstract class Human
    {
        public abstract string Firstname { get; set; }
        public abstract string Lastname { get; set; }

        public Human(string inputFName, string inputLName)
        {
            this.Firstname = inputFName;
            this.Lastname = inputLName;
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}

