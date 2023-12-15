using Microsoft.EntityFrameworkCore;
using P03_ManyToMany.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_ManyToMany.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01; Database=ManyToManyEf; Trusted_Connection=True; TrustServerCertificate=True";

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<StudentExam> StudentsExams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
