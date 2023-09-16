public class Program
{
    static void Main(string[] args)
    {
        Person s1 = new Student("Jane", "Velingrad", "Vasil Levski");

        Person e1 = new Employee("John", "Velingrad", "Lidl");

        Console.WriteLine(e1.GetNameAndAddress());
        Console.WriteLine(s1.GetNameAndAddress());
    }
}
