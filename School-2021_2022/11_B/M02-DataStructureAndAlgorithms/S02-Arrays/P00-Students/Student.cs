using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P00_Students
{
    public class Student
    {
        private readonly List<double> grades;

        public Student(string name, string @class)
        {
            Name = name;
            Class = @class;
            this.grades = new List<double>();
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public double AverageGrade { get => this.grades.Average(); }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public string PrintGrades()
        {
            return $"Name {this.Name} => " + string.Join(", ", this.grades);
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, class: {this.Class}, average grade: {this.AverageGrade}";
        }

    }
}
