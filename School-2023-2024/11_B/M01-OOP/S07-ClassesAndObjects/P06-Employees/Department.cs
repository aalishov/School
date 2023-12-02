using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Department
{
    private List<Employee> employees = new List<Employee>();

    public Department(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void AddMember(Employee employee)
    {
        employees.Add(employee);
    }

    public Employee? GetOldest()
    {
        Employee oldest = null;
        int maxAge = int.MinValue;

        foreach (Employee employee in employees)
        {
            if (employee.Age > maxAge)
            {
                maxAge = employee.Age;

                oldest = employee;
            }
        }
        return oldest;

        //return employees.OrderBy(x => x.Age).LastOrDefault();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Department name: {Name}");
        foreach (var e in employees)
        {
            sb.AppendLine($"\t{e.ToString()}");
        }
        return sb.ToString().TrimEnd();
    }
}

