public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        while (nums.Length > 1)
        {
            int[] condensed = new int[nums.Length - 1];
            for (int i = 0; i < condensed.Length; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];
            }
            nums = condensed;
        }
        Console.WriteLine(nums[0]);
    }
}

