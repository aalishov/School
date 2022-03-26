namespace P04_LoginForm.Data
{
    using Microsoft.EntityFrameworkCore;
    using P04_LoginForm.Data.Models;
    public class AppDbContext : DbContext
    {
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-L9E7KFT\SQLEXPRESS;Database=LoginForm;Integrated Security=true");
            }
        }
    }
}
