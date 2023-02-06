namespace P05_StudentsSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using Data.Models;

    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Initial Catalog=StudentsSystemEf; Integrated Security=true; Trusted_Connection=true";

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

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
            modelBuilder.Entity<StudentCourse>(
                option =>
            {
                option.HasKey(x => new { x.StudentId, x.CourseId });

            });
        }
    }
}
