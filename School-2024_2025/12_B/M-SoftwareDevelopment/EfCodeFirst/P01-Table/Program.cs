using P01_Table.Data;
using P01_Table.Data.Models;

namespace P01_Table
{
    public class Program
    {
        public static void Main()
        {
            AppDbContext context = new AppDbContext();

            List<Employee> employees = context.Employees
                .OrderBy(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToList();

            foreach (Employee employee in employees) {
                Console.WriteLine(employee.FirstName);
            }

            //Employee e1 = new Employee()
            //{
            //    FirstName="Jane",
            //    LastName="Johnson",
            //    Salary=2500,
            //    Address="Velingrad"
            //};
            //Employee e2 = new Employee()
            //{
            //    FirstName = "Alex",
            //    LastName = "Johnson",
            //    Salary = 2500,
            //    Address = "Velingrad"
            //};
            //context.Employees.AddRange(e1,e2);
            //context.SaveChanges();

            //Employee remove = context.Employees.Find(2);
            //if (remove != null)
            //{
            //    context.Employees.Remove(remove);
            //    context.SaveChanges();
            //}

            foreach (Employee employee in context.Employees)
            {
                employee.Salary = employee.Salary * 1.1;
                context.Update(employee);
            }
            context.SaveChanges();

        }
    }
}
