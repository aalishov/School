using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Department department = new Department();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] info = Console.ReadLine().Split(" ");
            department.AddMember(new Employee(info[0], int.Parse(info[1])));
        }

        Console.WriteLine(new String('*',15));
        List<Employee> list = department.GetOlderThen();
        foreach (var e in list)
        {
            Console.WriteLine($"{e.Name} - {e.Age}");
        }
    }
}

