public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = nums.Length-1; i >= 0; i--)
        {
            Console.Write($"{nums[i]} ");
        }
        Console.WriteLine();
    }
}

