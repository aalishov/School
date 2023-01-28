namespace P01_Cars.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_Cars.Data.Models;

    public class AppDbContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=STEM-13\\MSSQLSERVER01;Initial Catalog=ASP_Cars; Integrated Security=true; ");
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
