using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccount
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
