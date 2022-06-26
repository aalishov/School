using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : IComparable<Student>
{
    public Student(string name, double averageGrade)
    {
        this.Name = name;
        this.AverageGrade = averageGrade;
    }

    public string Name { get; set; }
    public double AverageGrade { get; set; }

    public int CompareTo(Student? other)
    {
        if (this.AverageGrade > other.AverageGrade)
        {
            return 1;
        }
        if (this.AverageGrade < other.AverageGrade)
        {
            return -1;
        }
        return this.Name.CompareTo(other.Name);
    }
}

