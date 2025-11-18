public class Program
{

    public static void Main()
    {
        Console.WriteLine(long.MaxValue);

        Console.Write("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        int b = int.Parse(Console.ReadLine());

        int area = a * b;
        Console.WriteLine($"Area = {area}");
    }
}

