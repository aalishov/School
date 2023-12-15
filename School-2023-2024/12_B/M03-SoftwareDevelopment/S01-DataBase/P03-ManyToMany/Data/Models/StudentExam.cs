using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_ManyToMany.Data.Models
{
    [PrimaryKey(nameof(StudentId), nameof(ExamId))]

    public class StudentExam
    {
        //public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int ExamId { get; set; }
        public virtual Exam Exam { get; set; }

      
    }
}
