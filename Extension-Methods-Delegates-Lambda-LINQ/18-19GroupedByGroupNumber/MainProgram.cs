//Problem 18. Grouped by GroupNumber
//Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//Use LINQ.
//Problem 19. Grouped by GroupName extensions
//Rewrite the previous using extension methods.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_19GroupedByGroupNumber
{
    class MainProgram
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            List<double> marksA = new List<double>();
            marksA.Add(4);
            marksA.Add(6);
            marksA.Add(2);
            marksA.Add(2);
            List<double> marksB = new List<double>();
            marksB.Add(4);
            marksB.Add(3);
            marksB.Add(6);
            marksB.Add(4);
            List<double> marksC = new List<double>();
            marksC.Add(2);
            marksC.Add(3);
            marksC.Add(2);
            marksC.Add(6);
            students.Add(new Student()
            {
                Email = "georgi.mirchev@abv.bg",
                FirstName = "Georgi",
                FN = "8361706384",
                GroupNumber = 2,
                LastName = "Mirchev",
                Marks = marksA
            });
            students.Add(new Student()
            {
                Email = "Ivan.Ivanov@mail.bg",
                FirstName = "Ivan",
                FN = "1537264938",
                GroupNumber = 3,
                LastName = "Ivanov",
                Marks = marksB
            });
            students.Add(new Student()
            {
                Email = "vasil.vasilev@abv.bg",
                FirstName = "Vasil",
                FN = "8374629381",
                GroupNumber = 2,
                LastName = "Vasilev",
                Marks = marksC
            });
            //Using Linq
            Console.WriteLine("----With Linq----");
            Console.WriteLine();
            var result = students.OrderBy(st => st.GroupNumber);
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine("---- With extension----");
            Console.WriteLine();
            //Using Extensions
            var resultWithExtensions = students.OrderByGroupNumber();
            foreach (var resultWithExtension in resultWithExtensions)
            {
                Console.WriteLine(resultWithExtension);
            }
        }
    }
}
