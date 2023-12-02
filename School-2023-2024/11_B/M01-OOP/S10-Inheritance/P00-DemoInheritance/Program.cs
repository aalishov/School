
public class Program
{
    public static void Main()
    {
        Person p1 = new Employee("John", 26, "Microsoft");
        Student p2 = new Student("Jane", 15, "Vasil Levski");

        Console.WriteLine(p2.AverageGrade);

    }
}
