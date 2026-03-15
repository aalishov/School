public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[] nums = new int[n];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"Sum = {nums.Sum()}");
        Console.WriteLine($"Min = {nums.Min()}");
        Console.WriteLine($"Max = {nums.Max()}");
        Console.WriteLine($"Average = {nums.Average()}");
    }
}

