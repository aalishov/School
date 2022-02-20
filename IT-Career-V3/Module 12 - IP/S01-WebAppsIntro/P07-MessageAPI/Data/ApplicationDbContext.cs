using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P07_MessageAPI.Data.Models;
namespace P07_MessageAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Message> Messages { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
