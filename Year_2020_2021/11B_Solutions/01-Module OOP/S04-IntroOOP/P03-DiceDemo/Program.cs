using System;
using System.Data.SqlTypes;

namespace P03_DiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice d6 = new Dice();
            Dice d8 = new Dice();

            Student firstStudent = new Student();
            firstStudent.FirstName = "Ivan";
            firstStudent.LastName = "Ivanov";
            firstStudent.Age = 12;
            firstStudent.Address = "Plovdiv";

            Student s1 = new Student();
            s1.FirstName = "Krasimir";
            s1.LastName = "Ivanov";
            s1.Age = 16;
            s1.Address = "Velingrad";
            s1.AvergageGrade = 5.2;

            Console.WriteLine(s1.ReturnStudentGrade());
            Console.WriteLine(firstStudent.ReturnStudentGrade());
            Console.WriteLine(s1.ReturnStudentAddress());
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double AvergageGrade { get; set; }

        public string ReturnStudentGrade()
        {
            return $"{this.FirstName} {this.LastName}: {this.AvergageGrade:f2}";
        }
        public string ReturnStudentAddress()
        {
            return $"{this.FirstName} {this.LastName}: {this.Address}";
        }
    }
    class Dice
    {
        public int Sides { get; set; }

        public string Type { get; set; }

        public void Roll()
        {

        }
    }
}
