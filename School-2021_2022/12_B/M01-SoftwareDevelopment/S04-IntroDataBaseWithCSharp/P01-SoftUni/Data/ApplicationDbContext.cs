using Microsoft.EntityFrameworkCore;
using P01_SoftUni.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_SoftUni.Data
{
    public class ApplicationDbContext : DbContext
    {
        private string connectonString = "Server=DESKTOP-9B09LE0; Database=Students; Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectonString);
            }
        }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
