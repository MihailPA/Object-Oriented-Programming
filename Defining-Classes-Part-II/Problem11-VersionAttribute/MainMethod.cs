using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11_VersionAttribute
{
    [Version("2.11")]

    class MainMethod
    {
        static void Main()
        {
            Type type = typeof(MainMethod);
            object[] attribute = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attribute)
            {
                Console.WriteLine("Version = {0}", item.Version);
            }
        }
    }
}
