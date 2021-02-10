using OnlineStore.Data;
namespace OnlineStore.DataSeeder
{
    using OnlineStore.Models;
    using System.Linq;
    public class CitiesSeeder
    {
        private readonly ApplicationDbContext dbContext;

        public CitiesSeeder(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public string Seed()
        {
            if (dbContext.Cities.Any())
            {
                return "Table cities already has records!";
            }
            dbContext.Cities.Add(new City { Name = "Velingad" });
            dbContext.Cities.Add(new City { Name = "Plovdiv" });
            dbContext.Cities.Add(new City { Name = "Varna" });
            dbContext.Cities.Add(new City { Name = "Burgas" });
            dbContext.Cities.Add(new City { Name = "Vidin" });
            dbContext.Cities.Add(new City { Name = "Pazardzhik" });
            dbContext.Cities.Add(new City { Name = "Sliven" });
            dbContext.Cities.Add(new City { Name = "Ruse" });
            dbContext.Cities.Add(new City { Name = "Lovech" });
            dbContext.Cities.Add(new City { Name = "Sofia" });
            dbContext.SaveChanges();
            return "Cities seeder done!";
        }
    }
}
