public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == n)
            {
                Console.WriteLine("Yes");
                Environment.Exit(0);
            }
        }
        Console.WriteLine("No");
    }
}


