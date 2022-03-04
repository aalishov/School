using Microsoft.EntityFrameworkCore;
using P03_PhoneBook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_PhoneBook.Data
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-L9E7KFT\\SQLEXPRESS;Database=phoneBookDb;Trusted_Connection=True;");
            }
        }
    }
}
