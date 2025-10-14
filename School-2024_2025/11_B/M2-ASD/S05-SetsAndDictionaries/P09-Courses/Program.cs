
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        while (true)
        {
            string[] info = Console.ReadLine().Split(" : ").ToArray();
            if (info[0] == "end")
            {
                break;
            }
           string nameCourses = info[0];
            string nameSt = info[1];
            if (courses.ContainsKey(nameCourses))
            {
                courses[nameCourses].Add(nameSt);
            }
            else
            {
                courses.Add(nameCourses, new List<string>() {nameSt});
            }
        }
        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count} ");
            foreach (var studentName in course.Value.OrderBy(x=>x))
            {
                Console.WriteLine($"-- {studentName}");
            }
        }
    }
}

