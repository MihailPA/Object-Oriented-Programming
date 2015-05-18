using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16StudentGroups
{
    public class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            var studentOne = new Student("Liutvi", "Mestan", "111213", "0899335373",
                "liutvi.mestan@abv.bg", new List<double> { 2.0, 3.0, 6.0, 6.0 }, new Group(2, "History"));
            students.Add(studentOne);

            var studentTwo = new Student("Sergei", "Stanishev", "111214", "0896353625",
               "stanishkata@hotmail.com", new List<double> { 2.0, 2.0, 3.0, 6.0 }, new Group(3, "Music"));
            students.Add(studentTwo);

            var studentThree = new Student("BatBoiko", "Borisov", "111215", "0888888888",
                "godboiko@gmail.com", new List<double> { 6.0, 6.5, 6.0 }, new Group(2, "Everything"));
            students.Add(studentThree);

            var studentFour = new Student("Cecka", "Tsatcheva", "111216", "02356356",
                "oiceckaohcecka@dir.bg", new List<double> { 6.0, 4.5, 2.0, 4.0, 5.0 }, new Group(1, "Mathematics"));
            students.Add(studentFour);

            var studentFive = new Student("Vouen", "Siderov", "111217", "+359896262626",
               "nevolencho@abv.bg", new List<double> { 2.0, 2.0 }, new Group(2, "Mathematics"));
            students.Add(studentFive);

            

            // PROBLEM 9  Selected students from group number 2

            var studentsFromGroup2 =
                from student in students
                where student.GroupNumber.GroupNumber == 2
                select student;

            //Console.WriteLine(string.Join("\n\n", studentsFromGroup2));

            // Sorted students from group 2 by First Name
            Console.WriteLine(Environment.NewLine + "Selected students from group 2 ,ordered by First Name\n");

            var sortedStudentsByFirstname =
                from student in studentsFromGroup2
                orderby student.FirstName
                select student;

            Console.WriteLine(string.Join("\n\n", sortedStudentsByFirstname));

            // PROBLEM 10  The same but USING extension methods

            //var studentsFromGroup2 = students.Where(student => student.GroupNumber.GroupNumber == 2);

            //var sortedStudentsByFirstname = studentsFromGroup2.OrderBy(x => x.FirstName);


            // PROBLEM 11
            Console.WriteLine("\nAll students with account in Abv.bg:\n");
            ExtractStudentsByEmail(students);

            //PROBLEM 12
            Console.WriteLine("\nStudents with phone in Sofia:\n");

            var studentsWithPhonesInSofia =
               from student in students
               where student.Tel.StartsWith("02") || student.Tel.StartsWith("+3592")
               select student;

            Console.WriteLine(string.Join("\n\n", studentsWithPhonesInSofia));

            // PROBLEM 13
            Console.WriteLine("\nStudents with have at least one excellent mark (6):\n");
            var studentsWithExcellentMark =
            from student in students
            where student.Marks.Contains(6.0)
            select new { FullName = student.FirstName + " " + student.LastName, Marks = string.Join(", ", student.Marks) };

            Console.WriteLine(string.Join("\n\n", studentsWithExcellentMark));

            // Problem 14
            Console.WriteLine("\nStudents with exactly two Poor Marks (2):\n");
            var studentsWith2PoorMarks = students.Where(stud => stud.Marks.FindAll(m => m == 2.0).Count == 2)
                .Select(x => new { FullName = x.FirstName + " " + x.LastName, Marks = string.Join(", ", x.Marks) });

            Console.WriteLine(string.Join("\n\n", studentsWith2PoorMarks));

            // PROBLEM 15
            Console.WriteLine("\nSudents enrolled in 2006:\n");
            var studentsEnrolled2006 = students.Where(x => x.FacNumber[4] == '0' && x.FacNumber[5] == '6').
                Select(x => new { FullName = x.FirstName + " " + x.LastName, FacNumber = x.FacNumber });
            Console.WriteLine(string.Join("\n\n", studentsEnrolled2006));

            // PROBLEM 16
            Console.WriteLine("\nAll students in Mathematics department:\n");
            var studentsMath = students.Where(x => x.GroupNumber.DepartmentName == "Mathematics").
                Select(x => new { FullName = x.FirstName + " " + x.LastName, Department = x.GroupNumber.DepartmentName });

            Console.WriteLine(string.Join("\n\n", studentsMath));

        }

        public static void ExtractStudentsByEmail(List<Student> students)
        {
            var studentsWithAbvAccount = new List<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                int startIndex = students[i].Email.Length - 6;
                string abv = students[i].Email.Substring(startIndex);
                if (abv.Equals("abv.bg"))
                {
                    studentsWithAbvAccount.Add(students[i]);
                }
            }
            Console.WriteLine(string.Join("\n\n", studentsWithAbvAccount));
        }
    }
}
