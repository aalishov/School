public class Program
{
    public static int[] arr;
    public static void Main()
    {
        Console.WriteLine("Ënter length: ");
        int length = int.Parse(Console.ReadLine());
        arr = new int[length];
        if (length >= 2 && length <= 60)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter elemnt {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Average(k));

        Console.WriteLine($"Index of max element: {Array.IndexOf(arr,arr.Max())}");
        Console.WriteLine($"Max element: {arr.Max()}");
    }

    private static double Average(int k)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= -10 && arr[i] <= 10 && arr[i] % k == 0)
            {
                sum += arr[i];
                count++;
            }
        }
        double average = sum / count;
        return average;
    }
}
