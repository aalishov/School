public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine($"Min = {nums.Min()}");
        Console.WriteLine($"Max = {nums.Max()}");
        Console.WriteLine($"Sum = {nums.Sum()}");
        Console.WriteLine($"Average = {nums.Average()}");
    }
}

