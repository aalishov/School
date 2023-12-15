using System.Collections;
using System.Text;

public partial class Program
{
    public static void Main()
    {
        Person s = new Student("John", 14, "Vasil Levski");
        Person s1 = new Student("Jane", 14, "Vasil Levski");
        Person e = new Employee("John", 14);

        School s2 = new School();
        s2.Students.Add((Student)s);
        s2.Students.Add((Student)s1);


        foreach (var item in s2)
        {
            Console.WriteLine(item);
        }
    }


    public sealed class School:IEnumerable<Student>
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                yield return Students[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
