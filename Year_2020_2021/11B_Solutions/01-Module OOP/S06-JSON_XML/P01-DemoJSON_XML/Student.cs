namespace P01_DemoJSON_XML
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private School school;

        public Student(string firstName, string lastName, int age, School school, double[] grades)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.School = school;
            this.Grades = grades;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be null or empty string!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public School School
        {
            get { return this.school; }
            set { this.school = value; }
        }

        public double[] Grades { get; set; }
    }
}
