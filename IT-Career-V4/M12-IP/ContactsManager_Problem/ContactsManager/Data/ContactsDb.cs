using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ContactsDb : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=STEM-13\\MSSQLSERVER01;Database=ContactsDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
