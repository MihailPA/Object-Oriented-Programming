//Problem 17. Longest string• Write a program to return the string with maximum length from an array of strings.
//• Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    public class LongestStr
    {
        public static void Main()
        {

            string[] array = new string[]
            { 
                "Georgi Ivanov", 
                "Stanislav Angelov",
                "Angel Angelov", 
                "Valentin Stoqnov", 
                "Zdravka Manoleva",
                "Valentin Valentinov"
            };
            Console.WriteLine(LongestString(array));
            Console.WriteLine(array.LongestString().ToArray().First());
            
        }
        public static string LongestString(string[] array)
        {
            int longest = array.Max(x => x.Length);
            var m = from str in array
                   where str.Length == longest
                   select str;
            return m.ToArray().First();
        }
    
    }
}
