using Microsoft.EntityFrameworkCore;
using P01_OneToOne.Data;
using P01_OneToOne.Data.Models;

namespace P01_OneToOne
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main(string[] args)
        {
            //foreach (var p in context.People
            //    //.Include(nameof(Passport))
            //    .ToList())
            //{
            //    Console.WriteLine( $"{p.FirstName} => {p.Passport.Number}");
            //}

            foreach (var passport in context.Passports.ToList())
            {
                string name = passport.Person != null ? passport.Person.FirstName : "n/a";
                Console.WriteLine( $"{passport.Number} - {name}");
            }
        }
    }
}
