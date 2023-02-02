namespace P03_EfManyToMany.Data.Models
{
    public class StudentExam
    {
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int ExamId { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
