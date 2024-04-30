using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40_People
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int age, double wage, int workHours) : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkHours = workHours;
        }

        public double Wage { get; private set; }

        public int WorkHours { get; private set; }

        public double Salary(double wage,double workHours)
        { 
            return wage* workHours;
        }
        public override string ToString()
        {
            return base.ToString() + $", salary: ${Salary(Wage,WorkHours):f2}";
        }
    }
}
