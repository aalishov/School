using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P00_Students
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string school, double averageGrade, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            School = school;
            AverageGrade = averageGrade;
            Address = address;
        }

        public Student() : this("n/a", "n/a") { }

        public Student(string firstName, string lastName, int age, string school, string address) : this(firstName, lastName, age, school, 0, address) { }

        public Student(string firstName, string lastName) : this(firstName, lastName, -1, "n/a", 0, "n/a") { }

        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "n/a", "n/a") { }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string School { get; set; }

        public double AverageGrade { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            string averageGrade = AverageGrade == 0 ? "n/a" : AverageGrade.ToString();
            string age = Age == -1 ? "n/a" : Age.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName}");
            sb.AppendLine($"Age: {age}");
            sb.AppendLine($"School: {School}");
            sb.AppendLine($"Average grade: {averageGrade}");
            sb.AppendLine($"Address: {Address}");
            return sb.ToString().TrimEnd();
        }
    }
}
