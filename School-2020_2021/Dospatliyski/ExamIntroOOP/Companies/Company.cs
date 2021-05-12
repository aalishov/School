using System;
using System.Collections.Generic;
using System.Text;

namespace Companies
{
    public class Company
    {
        public readonly List<Employee> employees;
        private string name;

        public Company(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.employees = new List<Employee>();
        }

        public string Name
        {
            get => name; set
            {
                if (value.Length<2)
                {
                    throw new ArgumentException("");
                }
                name = value;
            }
        }

        public string City { get; set; }

        public void Add(Employee employ)
        {
            employees.Add(employ);
        }

    }
}
