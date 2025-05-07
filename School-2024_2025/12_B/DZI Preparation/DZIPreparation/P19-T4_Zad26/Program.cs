using System.Linq;
using System.Text;

public class Program
{
    private static List<Student> students = new List<Student>();
    private static StringBuilder sb = new StringBuilder();
    public static void Main(string[] args)
    {
        try
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                double points = double.Parse(input[1]);
                students.Add(new Student(name, points));
            }


            sb.AppendLine($"Брой на студентите явили се на изпита: {students.Count(x => x.Points != -1)}");
            sb.AppendLine($"Среден резултат от изпита: {students.Where(x => x.Points != -1).Average(x => x.Points)}");
            double maxPoints = students.Max(x => x.Points);
            sb.AppendLine("Студенти с най-висок резултат: ");
            foreach (Student student in students.Where(x => x.Points == maxPoints))
            {
                sb.AppendLine($"\t{student.Name} -> {student.Points}");
            }
        }
        catch (Exception ex) 
        {
            sb.AppendLine(ex.Message);
        }

        Console.WriteLine(sb.AppendLine().ToString().TrimEnd());
        File.WriteAllText($"{Guid.NewGuid().ToString()}.txt", sb.AppendLine().ToString().TrimEnd());
    }
}

public class Student
{
    public Student(string name, double points)
    {
        Name = name;
        Points = points;
    }

    public string Name { get; set; }
    public double Points { get; set; }
}