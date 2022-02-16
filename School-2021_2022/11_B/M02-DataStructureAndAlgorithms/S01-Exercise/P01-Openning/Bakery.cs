using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_Openning
{
    public class Bakery
    {
        private readonly ICollection<Employee> data;
        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => this.data.Count; }
        public void Add(Employee employee)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            return this.data.Remove(GetEmployee(name));
        }
        public Employee GetOldestEmployee()
        {
            return this.data.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public Employee GetEmployee(string name)
        {
            return this.data.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach (var employee in this.data)
            {
                sb.AppendLine(employee.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public override string ToString()
        {
            return Report();
        }
    }
}
