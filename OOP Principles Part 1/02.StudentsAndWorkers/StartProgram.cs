using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class StartProgram
    {
        static void Main()
        {
            Random rand = new Random(); //Random used for generating grades, money and etc..

            //Initialize 10 students
            List<Student> students = new List<Student>();
            students.Add(new Student("Mihail", "Asenov", rand.Next(1, 12)));
            students.Add(new Student("Ivan", "Ivanov", rand.Next(1, 12)));
            students.Add(new Student("Krum", "Georiev", rand.Next(1, 12)));
            students.Add(new Student("Georgi", "Iliev", rand.Next(1, 12)));
            students.Add(new Student("Sretan", "Iosich", rand.Next(1, 12)));
            students.Add(new Student("Panko", "Ivanovv", rand.Next(1, 12)));
            students.Add(new Student("Aleksandar", "Milev", rand.Next(1, 12)));
            students.Add(new Student("Gavril", "Ortomarov", rand.Next(1, 12)));
            students.Add(new Student("Stoqn", "Radichkov", rand.Next(1, 12)));
            students.Add(new Student("Nikolay", "Kolev", rand.Next(1, 12)));

            Console.WriteLine(" Students (Sorted by grades ascending) ");

            //Test for students (Sort by grades ascending)
            Console.WriteLine();
            Console.WriteLine(new string('.', 80));
            var result = from student in students
                         orderby student.Grade
                         select student;
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('.', 80));
            Console.WriteLine();
            Console.WriteLine(" Workers (Sorted money per hour - descending ");
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));
            //Test for workers (Sort by grades descending)
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Angel", "Angelov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Iosif", "Iosifof", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Trandamir", "Trandamiev", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Joro", "Petkov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Vencislavo", "Iliev", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Dimitar", "Ivanov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("STanislav", "Stoev", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Hristo", "Georgiev", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Alexander", "Cankov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Tosho", "Toshkov", rand.Next(100, 400), rand.Next(2, 8)));
            var resultWorkers = from worker in workers
                                orderby worker.MoneyPerHour() descending
                                select worker;
            foreach (var worker in resultWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine(new string('.', 80));
            Console.WriteLine();
            Console.WriteLine("(Sorted by First and Last name)");
            Console.WriteLine();
            Console.WriteLine(new string('.', 80));

            List<Human> mergedList = new List<Human>();
            for (int i = 0; i < students.Count; i++)
            {
                mergedList.Add(students[i]);
            }
            for (int i = 0; i < workers.Count; i++)
            {
                mergedList.Add(workers[i]);
            }
            //Printing students and workers sorted by first name and lastname
            var finalResult = mergedList.OrderBy(human => human.Firstname).ThenBy(human => human.Lastname);
            foreach (var human in finalResult)
            {
                Console.WriteLine(human);
            }
        }
    }
}
