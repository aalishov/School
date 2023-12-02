
public class Program
{
    public static void Main()
    {
        Student s1 = new Student("John", 14);
        Console.WriteLine(s1.Grow());
        s1.AddGrade(5);
        s1.AddGrade(6);
        Console.WriteLine(s1);
        Console.WriteLine(s1.Grow());
        Console.WriteLine(s1);
        
    }
}
