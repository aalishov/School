using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_EfManyToMany.Data.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<StudentExam> StudentsExams { get; set; } = new List<StudentExam>();
    }
}
