using Microsoft.EntityFrameworkCore;
using P03_ManyToMany.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_ManyToMany.Data
{
    internal class AppDbContext:DbContext
    {
        private const string ConnectionString = "Server=.;Database=efManyToManyDb;Trusted_Connection=True;";

        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentExam> StudentsExams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentExam>()
                                .HasKey(se => new { se.StudentId, se.ExamId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
