using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Tomcats : Cat
    {
        public Tomcats(string name, int age)
            : base(name, Gender.Male, age)
        {
        }
    }
}
