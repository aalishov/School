namespace P01_EFCreateDB.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_EFCreateDB.Data.Models;

    public class ApplicationDbContext : DbContext
    {
        private const string ConnectionString = "Server=.;Database=demoDb;Trusted_Connection=True;";
        
        public virtual DbSet<Town> Towns { get; set; }

        public virtual  DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
