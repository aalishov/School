using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{
    private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01;Initial Catalog=EFManyToMany; Integrated Security=true; Trust Server Certificate=True";
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
        modelBuilder.Entity<StudentExam>
        (se =>
             se.HasKey(k => new { k.StudentId, k.ExamId })
        );

        base.OnModelCreating(modelBuilder);
    }
}

