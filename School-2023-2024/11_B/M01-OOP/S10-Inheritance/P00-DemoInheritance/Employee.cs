using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee : Person
{
    public Employee(string name, int age, string company) : base(name, age)
    {
        Company = company;
    }

    public string Company { get; private set; }

    public override string ToString()
    {
        //return $"Name: {Name}, age: {Age}, company: {Company}";
        return $"{base.ToString()}, company: {Company}";
    }
}

