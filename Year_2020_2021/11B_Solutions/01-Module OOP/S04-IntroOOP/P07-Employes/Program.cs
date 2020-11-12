using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    public static void Main()
    {

        Employee employee = new Employee("Ivan", 610m, "Programmer", "Web", "asdas@dasd", 15);

        Console.WriteLine(employee);

        //List<Employee> employees = new List<Employee>();

        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    string[] line = Console.ReadLine()
        //        .Split(' ')
        //        .ToArray();

        //    string name = line[0];
        //    decimal salary = decimal.Parse(line[1]);
        //    string position = line[2];
        //    string department = line[3];
        //    string email = "n/a";
        //    int age = -1;

        //    if (line.Length == 6)
        //    {
        //        email = line[4];
        //        int.TryParse(line[5], out age);
        //    }
        //    else if (line.Length == 5)
        //    {
        //        if (line[4].Contains("@"))
        //        {
        //            email = line[4];
        //        }
        //        else if (int.TryParse(line[4], out _))
        //        {
        //            age = int.Parse(line[4]);
        //        }
        //    }

        //    employees.Add(new Employee(name, salary, position, department, email, age));
        //}

        //Console.WriteLine(new string('*', 50));

        //foreach (var employee in employees.OrderByDescending(e => e.Salary))
        //{
        //    Console.WriteLine(employee);
        //}
    }
}

