//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Divisibleby7and3
{
    class Divisibleby7and3
    {
            static void Main(string[] args)
            {
                int[] numbers = new int[] { 1, 12, 13, 24, 65, 56, 7, 14, 25, 27, 63, 42, 21 };
                var result = numbers.Where(x => x % 7 == 0 && x % 3 == 0);
                Console.WriteLine(String.Join(", ", result));

                var result2 =
                    from number in numbers
                    where number % 7 == 0 && number % 3 == 0
                    select number;
                Console.WriteLine(String.Join(", ", result2));
            }
    }
}
