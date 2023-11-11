using P00_DemoDb.Data;
using P00_DemoDb.Data.Models;

namespace P00_DemoDb
{
    public class Program
    {
        // CRUD
        public static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            context.Employees.Add(new Employee()
            {
                FirstName = "Alex",
                MiddleName = "Peter",
                LastName = "Johnson",
                JobTitle = "WebDeveloper",
                Salary = 2000,
                HireDate = DateTime.UtcNow,
            });
            context.SaveChanges();
        }
    }
}