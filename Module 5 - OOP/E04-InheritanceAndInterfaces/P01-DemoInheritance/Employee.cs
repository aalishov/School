using System;
using System.Collections.Generic;
using System.Text;

namespace P01_DemoInheritance
{
    public class Employee:Person
    {
        public Employee(string name, decimal salary) : base(name)
        {
            this.Salary = salary;
        }
        public string Company { get; set; }
        public decimal Salary { get; set; }
    }
}
