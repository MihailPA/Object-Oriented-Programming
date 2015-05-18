//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03StudentClass
{
    class StudentMain
    {
        static void Main()
        {
            Student test = new Student
                (
                "Vasil", 
                "Ivanov", 
                "Karadjov", 
                "555-55-7459", 
                "Sofia", 
                "0899 150 360",
                "karadjov@abv.bg", 
                3, 
                Universities.SU, 
                Faculty.Phylosophy, 
                Specialty.Psychology
                );

            
            Student test2 = new Student
                (
                "Todor", 
                "Vasilev", 
                "Tomov",
                "235-55-8879",
                "Gotse Delchev",
                "0895 600 254",
                "todortomov@abv.bg",
                3,
                Universities.SU,
                Faculty.ComputerScience,
                Specialty.SoftwareEngineering
                );

            
            Student test3 = new Student
                (
                "Ivan",
                "Petrov",
                "Dimitrov",
                "456-89-4759",
                "Some other address",
                "0899 828 500",
                "vankata@abv.bg",
                3,
                Universities.UNSS,
                Faculty.Economy,
                Specialty.BusinessAdministration
                );

            bool compare1and2 = test.Equals(test2);
            bool compare1and3 = test.Equals(test3);
            bool compareWithOperators1and2 = test == test2;
            bool compareWithOperators1and3 = test == test3;
            int newHashCode = test.GetHashCode();

            Console.WriteLine(test); 
            Console.WriteLine("Compare student 1 and student 2 using Equals: {0}\n" +
                              "Compare student 1 and student 3 using Equals: {1}\n" +
                              "Compare student 1 and student 2 using ==: {2}\n" +
                              "Compare student 1 and student 3 using ==: {3}\n",
                              compare1and2, compare1and3, compareWithOperators1and2, compareWithOperators1and3);
            Console.WriteLine("New HashCode of student 1: {0}", newHashCode);

            Student cloned = test.Clone() as Student;

            Console.WriteLine("test.CompareTo(test2): {0}", test.CompareTo(test2)); 
            Console.WriteLine("test.CompareTo(test3): {0}", test.CompareTo(test3)); 

            Console.WriteLine("Cloned == test? {0}", cloned == test);
            test = test2; 
            Console.WriteLine("Cloned == test after changing test? {0}", test == cloned);
        }
    }
}

