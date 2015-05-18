//Problem 3. First before last
//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
//Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//Problem 5. Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{

    public class MainProgram
    {
        public static void Main()
        {
            Student[] arrayOfStudents =
            {
                new Student("Georgi", "Ivelinov", 22),
                new Student("Pesho", "Tenzuhov", 15),
                new Student("Zravka", "Kuchkova", 108),
                new Student("Iveuin", "Anastasov", 21),
                new Student("Goshko", "Troshko", 16),
                new Student("Ivan", "Manolev", 18),
                new Student("Konstadin", "Kostadinov", 25),
                new Student("Mihail", "Mihov", 33),
                new Student("BatBoiko", "Borisov", 22)
            };

            Console.WriteLine("All students:\n");
            foreach (var item in arrayOfStudents)
            {
                Console.WriteLine(item);
            }

         

            Console.WriteLine("\nStudents whose first name is before their last alphabetically:\n");

            PrintCollection(SelectByFirstNameBeforeLastName(arrayOfStudents));

          

            var selectedByAge = arrayOfStudents.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();

            Console.WriteLine("\nStudents whose age is between 18 - 24:\n");
            PrintCollection(selectedByAge);

            

            Console.WriteLine("\nStudents sorted by first name,than by last name in descending order\n");

            var sortedByFirstAndLastNameDesc = arrayOfStudents.OrderByDescending(x => x.FirstName).ThenBy(x => x.LaststName);
            PrintCollection(sortedByFirstAndLastNameDesc);
        }


        
        private static IEnumerable<Student> SelectByFirstNameBeforeLastName(IEnumerable<Student> collection)
        {
            var result = collection.Where(x => x.FirstName[0] < x.LaststName[0]).ToArray();
            return result;
        }

        
        public static void PrintCollection(IEnumerable<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

    }
}
