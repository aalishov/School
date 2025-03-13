using OneToOne.Data;
using OneToOne.Data.Models;

namespace OneToOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            foreach (var item in context.People)
            {
                Console.WriteLine($"{item.Name} -> {item.Passport.Number}");
            }

        }

        private static void AddPeople(AppDbContext context)
        {
            context.People.Add(
                new Person()
                {
                    Name = "Roberto",
                    Salary = 43300,
                    Passport = new Passport() { Number = "K65LO4R7" }
                });
            context.People.Add(
                new Person()
                {
                    Name = "Tom",
                    Salary = 56100,
                    Passport = new Passport() { Number = "N34FG21B" }
                });
            context.People.Add(
                new Person()
                {
                    Name = "Yana",
                    Salary = 60200,
                    Passport = new Passport() { Number = "ZE657QP2" }
                });
            context.SaveChanges();
        }
    }
}
