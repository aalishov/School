namespace P03_ManyToMany.Data
{
    using Microsoft.EntityFrameworkCore;
    using P03_ManyToMany.Data.Models;

    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Exam> Exams { get; set; }

        public virtual DbSet<StudentExam> StudentsExams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=examsDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentExam>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.ExamId });
            });
        }
    }
}
