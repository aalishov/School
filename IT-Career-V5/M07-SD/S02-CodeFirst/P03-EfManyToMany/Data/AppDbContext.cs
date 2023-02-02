namespace P03_EfManyToMany.Data
{
    using Microsoft.EntityFrameworkCore;
    using Data.Models;

    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Initial Catalog=ManyToManyEf; Integrated Security=true; Trusted_Connection=true";

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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentExam>()
                .HasKey(e => new { e.StudentId, e.ExamId });
        }

    }
}
