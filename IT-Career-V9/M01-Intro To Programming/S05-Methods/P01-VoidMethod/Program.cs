public class Program
{
    public static void Main()
    {
        PrintName("John", 30);
        PrintLine();
        PrintSum(15, 25);
    }
    public static void PrintName()
    {
        Console.WriteLine("Name - John");
    }
    public static void PrintName(string name)
    {
        Console.WriteLine($"Name - {name}");
    }
    public static void PrintName(string name, int age)
    {
        Console.WriteLine($"Name: {name}, age: {age}");
    }
    public static void PrintLine()
    {
        Console.WriteLine("___________________");
    }
    public static void PrintSum(int a, int b)
    {
        Console.WriteLine($"Sum: {a+b}");
    }
}

