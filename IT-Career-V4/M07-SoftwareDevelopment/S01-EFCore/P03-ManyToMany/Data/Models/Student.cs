using System.Collections.Generic;

namespace P03_ManyToMany.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StudentExam> StudentsExams { get; set; } = new HashSet<StudentExam>();
    }
}
