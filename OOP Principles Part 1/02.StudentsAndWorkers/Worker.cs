using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Worker : Human
    {
        private const int WEEK_DAYS = 7;
        public override string Firstname { get; set; }

        public override string Lastname { get; set; }

        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string inputFName, string inputLName, int inputWeekSalary, int inputWorkHours)
            : base(inputFName, inputLName)
        {
            this.WeekSalary = inputWeekSalary;
            this.WorkHoursPerDay = inputWorkHours;
        }

        public int MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay / WEEK_DAYS;
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname + " -> " + "Money per hour: " + this.MoneyPerHour() ;
        }
    }
}
