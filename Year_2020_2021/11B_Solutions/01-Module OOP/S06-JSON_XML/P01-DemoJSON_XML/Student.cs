using System;
using System.Collections.Generic;
using System.Text;

namespace P01_DemoJSON_XML
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private School school;

        public Student(string firstName, string lastName, int age, School school,double[] grades)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.School = school;
            this.Grades = grades;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be null or empty string!");
                }
                firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public School School
        {
            get { return school; }
            set { school = value; }
        }

        public double[] Grades { get; set; }

    }
}
