using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Test
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.Append("  Hello guys!How you doin today?");
            Console.WriteLine(sb.GetSubString(3, 67));
        }
    }
}
