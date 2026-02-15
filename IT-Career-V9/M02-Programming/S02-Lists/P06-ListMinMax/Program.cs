public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse).ToList();

        List<int> result = nums
            .OrderBy(x => x)
            .Where(x => x == nums.Min() || x == nums.Max()).ToList();

        Console.WriteLine(string.Join(" ", result));
    }

    private static void Variant1()
    {
        List<int> nums = Console.ReadLine()!
                    .Split(" ")
                    .Select(int.Parse).ToList();

        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (var num in nums)
        {
            if (num < min) { min = num; }
            if (num > max) { max = num; }
        }

        List<int> result = new List<int>();
        foreach (var num in nums)
        {
            if (num == min)
            {
                result.Insert(0, num);
            }
            else if (num == max)
            {
                result.Add(num);
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
