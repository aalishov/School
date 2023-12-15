using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_ManyToMany.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<StudentExam> StudentsExams { get; set; } = new List<StudentExam>();
    }
}
