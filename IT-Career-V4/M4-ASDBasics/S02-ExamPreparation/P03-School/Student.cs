using System;
using System.Collections.Generic;
using System.Text;

namespace P03_School
{
    public class Student
    {
        public Student(){}
        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
        public string Name { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"Student {this.Name} has {this.Grade:f2}.";
        }
    }
}
