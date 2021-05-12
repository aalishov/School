using System;
using System.Collections.Generic;
using System.Text;

namespace Companies
{
    public class Employee
    {
        private string firstName;

        public Employee(string id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this.Salary = 500;
        }

        public Employee(string id, string firstName, string lastName, int age, decimal salary) : this(id, firstName, lastName, age)
        {
            Salary = salary;
        }

        public string Id { get; set; }
        public string FirstName
        {
            get => firstName; 
            set
            {
                if (value.Length<2||value.Length>8)
                {
                    throw new ArgumentException("Invalid emplyee first name!");
                }
                firstName = value;
            }
        }
        public string LastName { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName}  {this.LastName} with id: {this.Id}  and salary: {this.Salary:f2}";
        }
    }
}
