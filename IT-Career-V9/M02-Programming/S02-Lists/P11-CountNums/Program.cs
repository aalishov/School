public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()
             .Split(" ")
             .Select(int.Parse)
             .OrderBy(x => x)
             .ToList();

        List<int> uniqueNums = nums.Distinct().ToList();

        foreach (var num in uniqueNums)
        {
            // Console.WriteLine($"{num} -> {nums.Count(x => x == num)}");
            int count = 0;
            foreach (var n in nums)
            {
                if (num==n)
                {
                    count++;
                }
            }
            Console.WriteLine($"{num} -> {count}");
        }

    }
}

