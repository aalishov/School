using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_JSON
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, int age, List<int> grades)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grades = grades;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
        public double AverageGrade { get => this.Grades.Average(); }
    }
}
