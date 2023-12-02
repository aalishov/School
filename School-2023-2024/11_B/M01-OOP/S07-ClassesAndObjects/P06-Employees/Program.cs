public class Program
{
    public static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee(15);
        Employee e3 = new Employee("John", 34);
        Employee e4 = new Employee("Alex", 32);
        Department d = new Department("Developers");

        d.AddMember(e1);
        d.AddMember(e2);
        d.AddMember(e3);
        d.AddMember(e4);

        Console.WriteLine(d);
        Console.WriteLine($"Oldest member: {d.GetOldest()}");


    }
}
