using OnlineStore.Data;
using System;

namespace OnlineStore.DataSeeder
{
    public class Program
    {
        public static void Main()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            CitiesSeeder citiesSeeder = new CitiesSeeder(dbContext);

            Console.WriteLine(citiesSeeder.Seed());
            
        }
    }
}
