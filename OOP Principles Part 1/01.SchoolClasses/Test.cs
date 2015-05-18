using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace School
{
    class Test
    {
        public const int maxClassNumber = 30;
        public const int teachersCount = 4;
        public const int minLectures = 2, minExercises = 2;
        public const int maxLectures = 9, maxExercises = 5;

        public static string[] fnames = { 
                                        "Ivan",
                                        "Mihail",
                                        "Vasil",
                                        "Stoqn",
                                        "Plamen",
                                        "Ivo",
                                        "Dimitar",
                                        "Angel",
                                        "Zdravka",
                                        "Katerina",
                                        "Velio",
                                        "Ivelin",
                                        "Angelina",
                                        "Maria",
                                        "Dimitriq",
                                        "Neli",
                                        "Tanq",
                                        "Stefan",
                                        "Aleksandar",
                                        "Borislav"
                                    };

        public static string[] disciplines = 
    {
        "Maths",
        "Algebra",
        "Literature",
        "English",
        "Biology",
        "Music",
        "History",
        "Chemistry",
        "Religion",
        "Psychology",
        "Computer science"
    };
        public static string[] comments = 
    {
        "Fan of LiverpoolFC",
        "Love pets",
        "Specialist at psychology",
        "Speak five languages",
        "Has Ford Mustang"
    };


        public static Random rnd = new Random();

        static void Main()
        {
            // generate a school with semi-random records

            School school = new School("Telerik", SchoolType.SOU);

            for (int i = 0; i < fnames.Length - teachersCount; i++)
            {
                school.AddStudent(new Student(fnames[i], (byte)(i + 1)));
            }

            for (int i = 0; i < teachersCount; i++)
            {
                school.AddTeacher(new Teacher(fnames[fnames.Length - teachersCount + i], comments[rnd.Next(0, comments.Length)]));
                school[i].AddDiscipline(new Discipline(disciplines[rnd.Next(0, disciplines.Length)],
                                                                 rnd.Next(minLectures, maxLectures),
                                                                 rnd.Next(minLectures, maxLectures)));
            }

            // add a discipline to a teacher

            school.Teachers[2].AddDiscipline(new Discipline(disciplines[0], 5, 1));

            school.PrintRoster();
        }
    }
}