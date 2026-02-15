public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        string result = nums.Contains(n) ? "Yes" : "No";

        Console.WriteLine(result);
    }
}

