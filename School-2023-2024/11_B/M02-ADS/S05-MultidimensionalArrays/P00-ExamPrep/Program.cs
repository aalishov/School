public class Program
{
    public static void Main()
    {
        int[] nums = new int[] { 1, 2, 3, 4 };
        int[] nums1 = new int[10];

        int[,] num4 = new int[,] { { 1, 3, 5 }, { 2, 4, 6 } };

        Console.WriteLine($"Length: {num4.Length}");
        Console.WriteLine($"GetLength(0): {num4.GetLength(0)}");
        Console.WriteLine($"GetLength(1): {num4.GetLength(1)}");

        List<int> nums3 = new List<int>() { 1, 2, 3 };

        nums3.AddRange(new int[] { 2, 3, 4 });
        nums3.Insert(0, 1);
        bool isRemoved = nums3.Remove(0);
        int removedItemsCount = nums3.RemoveAll(x => x % 2 == 1);
        Console.WriteLine($"Removed items: {removedItemsCount}");
        Console.WriteLine($"Nums3: {nums3.Count}");
        Console.WriteLine($"Nums3: {nums3.Count()}");
    }
}

