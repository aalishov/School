public class Program
{
    private static StudentDatabase studentDatabase = new StudentDatabase();
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine($"Enter command: [A]dd, [R]emove, [I]nfo, [Av]erage, End");
            string[] cmd = Console.ReadLine().Split(" ");
            switch (cmd[0])
            {
                case "A":
                case "Add":
                    Student student = new Student(int.Parse(cmd[1]), cmd[2]);
                    studentDatabase.AddStudent(student);
                    Console.Write("Add scores to the student: ");
                    double[] scores = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                    student.Scores = scores.ToList();
                    break;
                case "R":
                case "Remove":
                    Console.WriteLine(studentDatabase.RemoveStudent(int.Parse(cmd[1])));
                    break;
                case "I":
                case "Info":
                    Console.WriteLine(studentDatabase.GetStudentInfo(int.Parse(cmd[1])));
                    break;
                case "Av":
                case"Average":
                    Console.WriteLine(studentDatabase.GetStudentAverageScore(int.Parse(cmd[1])));
                    break;
                case "End":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
public class Student
{
    public Student(int Id, string name)
    {
        this.Id = Id;
        Name = name;
        Scores = new List<double>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<double> Scores { get; set; }
}
public class StudentDatabase
{
    private readonly List<Student> students;
    public StudentDatabase()
    {
        students = new List<Student>();
    }
    public string AddStudent(Student student)
    {
        students.Add(student);
        return $"Student {student.Name} added";
    }
    public string RemoveStudent(int id)
    {
        Student student = students.FirstOrDefault(x => x.Id == id);
        if (student != null)
        {
            students.Remove(student);
            return $"Student {student.Name} removed";
        }
        else
        {
            return "Student not found";
        }
    }
    public string GetStudentInfo(int id)
    {
        Student student = students.FirstOrDefault(x => x.Id == id);
        if (student != null)
        {
            return $"{student.Name}\n\tScores: {string.Join(" ", student.Scores)}";
        }
        else
        {
            return "Student not found";
        }
    }
    public double GetStudentAverageScore(int id)
    {
        Student student = students.FirstOrDefault(x => x.Id == id);
        if (student != null)
        {
            return Math.Round(student.Scores.Average(),2);
        }
        else
        {
            return -1;
        }
    }
}
