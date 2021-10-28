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
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Worker name cannot be null, empty or whitespace.");
                }
                name = value;
            }
        }

        public int Experience { get; private set; }

        public string Description { get; private set; }

        public int Salary
        {
            get { return salary; }
            private set
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Worker {this.Name}");
            sb.AppendLine($"Experience: {this.Experience}");
            sb.AppendLine($"Description: {this.Description}");
            sb.AppendLine($"Desired salary: {this.Salary}");
            return sb.ToString().TrimEnd();
        }
    }
}
