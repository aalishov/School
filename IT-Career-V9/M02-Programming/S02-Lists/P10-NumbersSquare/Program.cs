public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Distinct()
            .Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x))
            .OrderByDescending(x => x)
            .ToList();

        Console.WriteLine(string.Join(" ", nums));
    }
}

