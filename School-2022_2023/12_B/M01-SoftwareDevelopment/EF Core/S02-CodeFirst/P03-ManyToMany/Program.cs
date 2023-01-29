public class Program
{
    private static AppDbContext context = new AppDbContext();
    public static void Main()
    {
        PrintData();
    }

    public static void PrintData()
    {
        Console.WriteLine($"{"Student",-10} {"Exam",-10}");
        foreach (var item in context.StudentsExams.ToList())
        {
            Console.WriteLine($"{item.Student.Name,-10} {item.Exam.Name,-10}");
        }
    }

    private static void InsertData()
    {
        Student s1 = new Student { Name = "Mila", Age = 15 };
        Student s2 = new Student { Name = "Toni", Age = 15 };
        Student s3 = new Student { Name = "Ron", Age = 15 };

        Exam e1 = new Exam() { Name = "Spring MVC" };
        Exam e2 = new Exam() { Name = "Neo4j" };
        Exam e3 = new Exam() { Name = "Oracle 11g" };

        context.StudentsExams.Add(new StudentExam() { Student = s1, Exam = e1 });
        context.StudentsExams.Add(new StudentExam() { Student = s1, Exam = e2 });
        context.StudentsExams.Add(new StudentExam() { Student = s2, Exam = e1 });
        context.StudentsExams.Add(new StudentExam() { Student = s3, Exam = e3 });
        context.StudentsExams.Add(new StudentExam() { Student = s2, Exam = e2 });
        context.StudentsExams.Add(new StudentExam() { Student = s2, Exam = e3 });

        if (!context.StudentsExams.Any())
        {
            context.SaveChanges();
        }
    }
}
