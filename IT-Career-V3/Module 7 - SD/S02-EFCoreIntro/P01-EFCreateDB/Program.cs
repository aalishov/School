namespace P01_EFCreateDB
{
    using P01_EFCreateDB.Data;
    using P01_EFCreateDB.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            //for (int i = 0; i < 50; i++)
            //{
            //    dbContext.Countries.Add(new Country() { Name = $"Coutry {i}" });

            //    dbContext.SaveChanges();
            //}
            List<Country> countries = dbContext.Countries
                .Where(x => x.Id > 4)
                .ToList();
            dbContext.Countries.RemoveRange(countries);
            dbContext.SaveChanges();

            countries = dbContext.Countries.ToList();
            foreach (var c in countries)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
