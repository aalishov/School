using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    private string ConnectionString = @"Server=STEM-13\MSSQLSERVER01;Initial Catalog=EFOneToOne; Integrated Security=true; Trust Server Certificate=True";
    public virtual DbSet<Passport> Passports { get; set; }
    public virtual DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Passport)
            .WithOne(pas => pas.Person)
            .HasForeignKey<Person>(p => p.PassportId);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        optionsBuilder.UseLazyLoadingProxies();
    }
}

