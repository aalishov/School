public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        int index = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= n)
            {
                index = i;
                break;
            }
        }

        int[] newNums = new int[nums.Length + 1];

        for (int i = 0; i < index; i++)
        {
            newNums[i] = nums[i];
        }
        newNums[index] = n;
        for (int i = index; i < nums.Length; i++)
        {
            newNums[i + 1] = nums[i];
        }
        Console.WriteLine($"nums: {string.Join(", ", nums)}");
        Console.WriteLine($"newNums: {string.Join(", ", newNums)}");
    }
}

