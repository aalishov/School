public class Program
{
    public static void Main()
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        int studentsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentsCount; i++)
        {
            string[] info = Console.ReadLine().Split(" ");
            string name = info[0];
            double grade = double.Parse(info[1]);

            if (students.ContainsKey(name))
            {
                students[name].Add(grade);
            }
            else
            {
                students.Add(name, new List<double>() { grade });
            }
        }

        foreach (var student in students)
        {
            string grades = string.Empty;
            foreach (var grade in student.Value) 
            {
                grades += $"{grade:f2} ";
            }

            Console.WriteLine($"{student.Key} - {grades} (avg: {student.Value.Average():f2})");
        }
    }
}