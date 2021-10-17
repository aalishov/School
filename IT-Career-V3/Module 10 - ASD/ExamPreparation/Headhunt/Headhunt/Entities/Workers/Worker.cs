using Headhunt.Entities.Workers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Headhunt.Entities.Workers
{
    public class Worker : IWorker
    {
        private string name;
        private int salary;

        public Worker(string name, int experience, string description, int salary)
        {
            this.Name = name;
            this.Experience = experience;
            this.Description = description;
            this.Salary = salary;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Worker name cannot be null, empty or whitespace.");
                }
                name = value;
            }
        }

        public int Experience { get; set; }

        public string Description { get; set; }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Worker salary cannot be zero or negative.");
                }
                salary = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Experience}";
        }
    }
}
