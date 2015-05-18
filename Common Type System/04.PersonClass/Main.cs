//Problem 4. Person class
//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    class Main
    {
        class MainMethod
        {
            static void Main()
            {
                Person gosho = new Person("Georgi Georgiev", 18);
                Person vanio = new Person("Ivan Ivanov");
                Person tosho = new Person("Todor Todorov", null);
                Console.WriteLine(gosho);
                Console.WriteLine(vanio);
                Console.WriteLine(tosho);
            }
        }
    }
}
