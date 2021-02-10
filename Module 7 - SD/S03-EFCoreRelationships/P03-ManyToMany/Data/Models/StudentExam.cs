namespace P03_ManyToMany.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class StudentExam
    {
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [ForeignKey(nameof(Exam))]
        public int ExamId { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
