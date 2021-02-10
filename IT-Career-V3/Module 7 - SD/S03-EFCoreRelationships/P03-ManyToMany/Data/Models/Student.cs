namespace P03_ManyToMany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        public Student()
        {
            this.Exams = new HashSet<StudentExam>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<StudentExam> Exams { get; set; }
    }
}
