public class Program
{
    public static void Main()
    {

        Console.WriteLine(IsContain(3, new int[] { 2,4,56}));
    }

    public static bool IsContain(int num, int[] nums)
    {
        bool result = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (num == nums[i])
            {
                return true;
            }
        }
        return result;
    }
}

