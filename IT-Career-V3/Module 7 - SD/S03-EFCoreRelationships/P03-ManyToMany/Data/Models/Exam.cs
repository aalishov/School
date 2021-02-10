using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_ManyToMany.Data.Models
{
    public class Exam
    {
        public Exam()
        {
            this.Students = new HashSet<StudentExam>(); 
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<StudentExam> Students { get; set; }
    }
}
