namespace P02_StudentsAppData
{
    using Microsoft.EntityFrameworkCore;
    using P02_StudentsAppData.Models;

    public class ApplicationDbContext : DbContext
    {
        private const string ConnectionString = "Server=.;Database=studentsDb;Trusted_Connection=True;";

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Town> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne(s =>s.School)
                .WithMany(s => s.Students)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
