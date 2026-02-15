using P03_ManyToMany.Data;
using P03_ManyToMany.Data.Models;

namespace P03_ManyToMany
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main()
        {
            InsertInitialData();
            PrintStudentsExams();
        }
        public static void PrintStudentsExams()
        {
            foreach (var item in context.StudentsExams.ToList())
            {
                Console.WriteLine($"{item.Student.Name} - {item.Exam.Name}");
            }
        }
        public static void InsertInitialData()
        {
            if (context.StudentsExams.Any()) { return; }

            Student s1 = new Student() { Name = "Mila" };
            Student s2 = new Student() { Name = "Toni" };
            Student s3 = new Student() { Name = "Ron" };

            Exam e1 = new Exam() { Name = "SpringMVC" };
            Exam e2 = new Exam() { Name = "Neo4j" };
            Exam e3 = new Exam() { Name = "Oracle11g" };

            List<StudentExam> studentExams = new List<StudentExam>()
            {
                new StudentExam(){Student=s1,Exam=e1},
                new StudentExam(){Student=s1,Exam=e2},
                new StudentExam(){Student=s2,Exam=e1},
                new StudentExam(){Student=s3,Exam=e3},
                new StudentExam(){Student=s2,Exam=e2},
                new StudentExam(){Student=s2,Exam=e3},
            };

            context.StudentsExams.AddRange(studentExams);
            context.SaveChanges();
        }
    }
}
