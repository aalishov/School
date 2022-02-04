using P01_OneToOne.Data;
using P01_OneToOne.Data.Models;
using System;

namespace P01_OneToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            Passport passport = new Passport() { Number = "12345" };
            Person person = new Person() { FirstName = "Alex", LastName = "Petrov", Salary = 256, Passport = passport };

            context.People.Add(person);
            context.SaveChanges();
        }
    }
}
