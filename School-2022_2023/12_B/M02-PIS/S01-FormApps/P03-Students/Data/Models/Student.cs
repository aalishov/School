using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Students.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AverageGrade { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
