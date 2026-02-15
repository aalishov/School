using DemoCodeFirst.Data;
using DemoCodeFirst.Data.Models;

namespace DemoCodeFirst
{
    public class Program
    {
        public static void Main()
        {
            AppDbContext context = new AppDbContext();

            Student s1 = new Student()
            {
                FirstName = "John",
                LastName = "Johnson"
            };

            context.Students.Add(s1);
            context.SaveChanges();
        }
    }
}
