using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    private List<int> grades = new List<int>();
    private string name;
    private int age;

    public Student(string name, int age = -1)
    {
        Name = name;
        Age = age;
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid name!");
            }
            name = value;
        }
    }

    //imutable
    public int Age
    {
        get { return age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid age!");
            }
            age = value;
        }
    }

    public double AverageGrade { get { return grades.Average(); } }

    public void AddGrade(int grade)
    {
        if (grade < 2 || grade > 6)
        {
            throw new ArgumentException("Invalid grade!");
        }
        grades.Add(grade);
    }

    public string Grow( )
    {
        Age++;
        return $"Student {Name}  growing! Age: {Age}";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Student info:");
        sb.AppendLine($"\tName: {Name}");
        sb.AppendLine($"\tAge: {Age}");
        string averageGrade = grades.Any() ? AverageGrade.ToString() : "n/a";
        sb.AppendLine($"\tAverage grade: {averageGrade}");
        return sb.ToString().TrimEnd();
    }
}
