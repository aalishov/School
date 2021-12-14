using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesEmployee
{
    public class Department
    {
        private List<Employee> employees;
        public Department()
        {
            this.employees = new List<Employee>();
        }
        public List<Employee> Employees
        {
            get { return this.employees; }
        }

        public void AddMember(Employee employee)
        {
            this.employees.Add(employee);
        }
        
        public Employee GetOldest()
        {
            return this.employees.OrderBy(x => x.Age).ThenByDescending(x=>x.Name).Last();
        }
    }
}
