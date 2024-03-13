public class Program
{
    public static void Main()
    {
        int[] nums = { 3, 15, 21, 24, 17, 9 };
        string result = MyArray.MyJoin(nums, " | ");
        string result2 = MyArray.MyJoin(MyArray.CreateRandomArray(10, -5.5, +5.5), " * ");
        string result3 = MyArray.MyJoin(nums.Where(x=>x%3==0&&x>15).ToArray());

        Console.WriteLine(result3);
    }
}
