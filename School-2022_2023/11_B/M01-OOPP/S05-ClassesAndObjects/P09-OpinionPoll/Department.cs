using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Department
{
    private readonly List<Employee> employees = new List<Employee>();

    public void AddMember(Employee employee)
    {
        employees.Add(employee);
    }

    public Employee GetOldest()
    {
        Employee oldest = employees
            .OrderBy(x => x.Age) //Сортиране - възходящ ред
            .LastOrDefault(); //Последния или null

        return oldest;
    }

    public List<Employee> GetOlderThen(int age = 30)
    {
        return employees.Where(x => x.Age >= age).ToList();
    }
}

