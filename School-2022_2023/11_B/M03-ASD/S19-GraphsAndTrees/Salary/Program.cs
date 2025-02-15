﻿namespace Salary
{
    public class Employee
    {
        public int Index { get; set; }
        public List<int> Managers { get; set; }
        public List<int> Employees { get; set; }
        public int Salary { get; set; }
        public Employee(int index)
        {
            Index = index;
            Salary = 0;
            Employees = new List<int>();
            Managers = new List<int>();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                employees[i] = new Employee(i);
            }

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var row = Console.ReadLine();

                for (int j = 0; j < numberOfEmployees; j++)
                {
                    if (row[j] == 'Y')
                    {
                        employees[i].Employees.Add(j);
                        employees[j].Managers.Add(i);
                    }
                }
            }
            var copy = employees.ToList();

            while (copy.Count() != 0)
            {
                var noManagers = copy.Where(x => x.Employees.Count() == 0).ToList();

                foreach (var noManager in noManagers)
                {
                    noManager.Salary = noManager.Salary == 0 ? 1 : noManager.Salary;
                    copy.Remove(noManager);

                    foreach (var manager in noManager.Managers)
                    {

                        employees[manager].Salary += noManager.Salary;
                        employees[manager].Employees.Remove(noManager.Index);
                    }
                }
            }
            Console.WriteLine(employees.Select(x => x.Salary).Sum());
        }
    }
}