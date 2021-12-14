using System;

namespace ClassesEmployee
{
    public class StartUp
    {
        public static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee(10);
            Employee employee3 = new Employee("John", 12);
            Console.WriteLine($"{employee1.Name}  {employee1.Age}");
        }
    }
}
