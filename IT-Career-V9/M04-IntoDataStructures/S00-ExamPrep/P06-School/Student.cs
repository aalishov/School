using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

public class Student
{
    private string name;

    public Student(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }

    public string Name
    {
        get { return name; }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be null or whitespace.");
            }
            if (value.Length < 2)
            {
                throw new ArgumentException("Name must be at least 2 characters long.");
            }
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException("Name must start with an uppercase letter.");
            }
            name = value;
        }
    }

    public double Grade { get; private set; }

    public override string ToString()
    {
        return $"Student {Name} has {Grade:f2}.";
    }
}

