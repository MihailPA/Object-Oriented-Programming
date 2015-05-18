using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16StudentGroups
{
    public class Group
    {

        public Group(int number, string name)
        {
            this.GroupNumber = number;
            this.DepartmentName = name;
        }

        public int GroupNumber { get; private set; }
        public string DepartmentName { get; private set; }

        public override string ToString()
        {
            return string.Format("Group number: {0}\nDepartment : {1}",
                this.GroupNumber, this.DepartmentName);
        }

    }
}
