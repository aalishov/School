public class Program
{
    public static void Main()
    {
        int wonCount = 0;

        string result = Console.ReadLine();
        if (result[0] > result[2]) { wonCount++; }

        result = Console.ReadLine();
        if (result[0] > result[2]) { wonCount++; }

        result = Console.ReadLine();
        if (result[0] > result[2]) { wonCount++; }

        Console.WriteLine($"Grigor won {wonCount} games.");
        Console.WriteLine($"Grigor lost {3-wonCount} games.");
    }
}

