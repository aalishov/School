public class Program
{
    public static void Main()
    {
        int[][] nums = new int[3][];

        for (int i = 0; nums.Length > i; i++)
        {
            nums[i] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(string.Join(", ", nums[i]));
        }

        int sum = 0;
        for (int rows = 0; rows < nums.Length; rows++) 
        { 
            for (int col = 0; col < nums[rows].Length; col++)
            {
                sum += nums[rows][col];
            }
        }
        Console.WriteLine($"Sum: {sum}");
    }
}