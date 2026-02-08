
public class Program
{
    public static void Main()
    {
        int n = 5;
        int[] nums = { 1, 2, 3, 4, };

        //ChangeN(ref n);
        ChangeN(n);
        ChangeNums(nums);

        Console.WriteLine($"n={n}");
        Console.WriteLine($"Nums= {string.Join(", ", nums)}");
    }

    // public static void ChangeN(ref int n)
    public static void ChangeN(int n)
    {
        for (int i = 0; i < 10; i++)
        {
            n++;
            //Console.WriteLine(n);
        }
    }
    public static void ChangeNums(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] *= 10;
        }
    }
}
