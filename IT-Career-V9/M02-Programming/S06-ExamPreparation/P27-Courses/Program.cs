public class Program
{
    private static Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? string.Empty;
            if (input == "end") { break; }
            string[] courseInfo = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            string courseName = courseInfo[0];
            string studentName = courseInfo[1];

            if (!courses.ContainsKey(courseName))
            {
                courses.Add(courseName, new List<string>());
            }
            courses[courseName].Add(studentName);
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            foreach (var student in course.Value)
            {
                Console.WriteLine($"--{student}");
            }
        }
    }
}