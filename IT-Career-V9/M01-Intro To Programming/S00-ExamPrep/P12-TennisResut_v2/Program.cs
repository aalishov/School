public class Program
{
    public static void Main()
    {
        int wonCount = GetResult() + GetResult() + GetResult();

        Console.WriteLine($"Grigor won {wonCount} games.");
        Console.WriteLine($"Grigor lost {3 - wonCount} games.");
    }
    public static int GetResult()
    {
        string result = Console.ReadLine();
        if (result[0] > result[2]) { return 1; }
        return 0;
    }
}

