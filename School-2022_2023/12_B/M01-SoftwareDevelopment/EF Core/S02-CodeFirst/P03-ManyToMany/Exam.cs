using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exam
{

    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public virtual ICollection<StudentExam> StudentsExams { get; set; } = new List<StudentExam>();
}

