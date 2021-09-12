using System;

namespace P09_Employees
{
  public  class Program
    {
      public  static void Main()
        {
            ContractEmployee employee1 = new ContractEmployee("1", "Alex", "Sofia", "Create app", "Web developers");
            FullTimeEmployee employee2 = new FullTimeEmployee("2", "John", "Sofia", "Create app", "DB Creator");

            Console.WriteLine(employee1.Show());
            Console.WriteLine(employee2.Show());
            Console.WriteLine(employee1.CalculateSalary(10));
            Console.WriteLine(employee2.CalculateSalary(10));
            Console.WriteLine(employee1.GetDepartment());
            Console.WriteLine(employee2.GetDepartment());
        }
    }
}
