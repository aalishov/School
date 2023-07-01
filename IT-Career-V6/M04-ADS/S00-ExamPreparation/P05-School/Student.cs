using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

public class Student
{
    public Student() { }

    public Student(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }

    public string Name { get; private set; }

    public double Grade { get; private set; }

    public override string ToString()
    {
        return $"Student {Name} has {Grade:f2}.";
    }
}

