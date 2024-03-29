public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(":").ToArray();
            if (input[0] == "end")
            {
                break;
            }
            string courseName = input[0];
            string studentName = input[1];
            if (courses.ContainsKey(courseName))
            {
                courses[courseName].Add(studentName);
            }
            else
            {
                courses.Add(courseName, new List<string>() { studentName });
            }
        }
        foreach (var course in courses.OrderByDescending(x=>x.Value.Count))
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            foreach (var student in course.Value )
            {
                Console.WriteLine($"-- {student}");
            }
        }
        
    }
}
