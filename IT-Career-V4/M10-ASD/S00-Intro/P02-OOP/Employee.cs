using System;
using System.Collections.Generic;
using System.Text;

public class Employee : Person
{
    public Employee(string name,double salary) : base(name)
    {
        this.Salary = salary;
    }

    public double Salary { get; set; }

    public override string ToString()
    {
        return base.ToString()+$", salary: {this.Salary:f3}";
    }
}

