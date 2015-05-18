//Problem 3. Animal hierarchy
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals.
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, 
//name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.AnimalHierarchy
{
    class MainMethod
    {
        static void Main()
        {
            Dog[] myDogs = 
            {
                new Dog("Riko",Gender.Male,1),
                new Dog("Balkan",Gender.Male,6),
                new Dog("Suzi",Gender.Female,5)
            };

            Console.WriteLine("...My Dogs...");

            PrintCollection(myDogs);
            Console.Write("Dogs sound:");
            myDogs[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myDogs));
            Console.WriteLine();

            Frog[] myFrogs = 
            {
                new Frog("GreenGoblin",Gender.Male,4),
                new Frog("Poison",Gender.Female,2),
                new Frog("Crastavata",Gender.Female,5)
            };

            Console.WriteLine("...My Frogs...");

            PrintCollection(myFrogs);
            Console.Write("Frog sound:");
            myFrogs[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myFrogs));
            Console.WriteLine();

            Cat[] myCats = 
            {
                new Cat("Pisana",Gender.Female,4),
                new Cat("Antonio",Gender.Male,5),
                new Cat("Anna",Gender.Female,7)
            };

            Console.WriteLine("...My Cats...");

            PrintCollection(myCats);
            Console.Write("Cat sound:");
            myCats[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myCats));
            Console.WriteLine();

            Kitten[] myKittens = 
            {
                new Kitten("Kitt",1),
                new Kitten("Kuti",1),
                new Kitten("Kati",2)
            };

            Console.WriteLine("...My Kittens...");
            PrintCollection(myKittens);
            Console.Write("Kittens sound:");
            myKittens[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myKittens));
            Console.WriteLine();

            Tomcats[] myTomcats = 
            {
                new Tomcats("Spinderman",2),
                new Tomcats("Batman",2),
                new Tomcats("Fred",2)
            };

            Console.WriteLine("...My Tomcats...");

            PrintCollection(myTomcats);
            Console.Write("Kittens sound:");
            myTomcats[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myTomcats));
            Console.WriteLine();
        }


        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
