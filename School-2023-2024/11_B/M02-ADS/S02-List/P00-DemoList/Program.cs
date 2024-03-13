using P00_Demo;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            nums.Add(new Random().Next(-10, 10));
        }
        //nums.Add(1);    
        //nums.Add(-1);

        //nums.Insert(0, 10);

        Console.WriteLine(string.Join(", ", nums));
        Console.WriteLine($"Count: {nums.Count}");
        Console.WriteLine($"Capacity: {nums.Capacity}");

        nums.Add(5);
        nums.Insert(0, 1);
        nums.InsertRange(0, new int[] { 5, 2, 4 });
        nums.Remove(5);
        nums.RemoveAt(0);
        nums.RemoveRange(0, 3);
        nums.RemoveAll(x => x < -5 || x > 5);
        bool isContains = nums.Contains(5);

        Console.WriteLine(nums.Max()); ;
    }


}

