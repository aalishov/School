public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(" ")
            .Select(x => int.Parse(string.Join("", x.Reverse())))
            .ToList();

        Console.WriteLine(nums.Sum());
    }

    private static void ReverseNumber()
    {
        int num = int.Parse(Console.ReadLine());

        List<int> digits = new List<int>();

        while (num != 0)
        {
            int result = num % 10;
            digits.Add(result);
            num /= 10;
        }

        int sum = 0;
        int m = 1;
        for (int i = digits.Count - 1; i >= 0; i--)
        {
            sum += digits[i] * m;
            m *= 10;
        }
        Console.WriteLine(sum);
    }
}

