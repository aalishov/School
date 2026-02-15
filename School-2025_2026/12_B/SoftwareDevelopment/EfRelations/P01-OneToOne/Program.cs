using P01_OneToOne.Data;
using P01_OneToOne.Data.Models;

namespace P01_OneToOne
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main()
        {
            InsertInitialData();
            PrintInfo();
        }

        public static void PrintInfo()
        {
            foreach (var item in context.People.ToList())
            {
                Console.WriteLine($"{item.FirstName} -> {item.Passport.Number}");
            }
        }

        public static void InsertInitialData()
        {
            Person p1 = new Person()
            {
                FirstName = "Roberto",
                Salary = 43300,
                Passport = new Passport() { Number = "K65LO4R7" }
            };
            Person p2 = new Person()
            {
                FirstName = "Tom",
                Salary = 56100,
                Passport = new Passport() { Number = "ZE657QP2" }
            };
            Person p3 = new Person()
            {
                FirstName = "Yana",
                Salary = 60200,
                Passport = new Passport() { Number = "N34FG21B" }
            };

            if (!context.People.Any())
            {
                context.People.AddRange(p1, p2, p3);
                context.SaveChanges();
            }
        }
    }
}
