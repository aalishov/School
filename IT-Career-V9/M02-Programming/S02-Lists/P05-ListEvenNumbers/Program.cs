public class Program
{
    public static void Main()
    {
        List<int> evenNums = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .Where(num => num % 2 == 0)
            .ToList();

        Console.WriteLine(string.Join(" ", evenNums));
    }

    private static void Variant1()
    {
        List<int> nums = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();
        List<int> evenNums = new List<int>();
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                evenNums.Add(num);
            }
        }
        Console.WriteLine(string.Join(" ", evenNums));
    }
}

