using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_19GroupedByGroupNumber
{
    public static class Extensions
    {
        public static IEnumerable<Student> OrderByGroupNumber(this List<Student> input)
        {
            var result = input.OrderBy(st => st.GroupNumber);
            return result;
        }
    }
}
