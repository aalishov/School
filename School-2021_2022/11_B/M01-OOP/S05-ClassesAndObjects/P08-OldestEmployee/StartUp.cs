using System;

namespace ClassesEmployee
{
    public class StartUp
    {
        public static void Main()
        {
            Department department = new Department();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                string name = info[0];
                int age = int.Parse(info[1]);
                department.AddMember(new Employee(name, age));
            }
            Employee employee = department.GetOldest();
            Console.WriteLine($"{employee.Name} {employee.Age}");
        }
    }
}
