public class Program
{
    private static int[] arr;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        arr = ReadArray(n);
        Console.WriteLine($"{Average():f2}");


    }
    public static int[] ReadArray(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    public static double Average()
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%7==0)
            {
                sum += arr[i];
                count++;
            }
        }
        return sum/(double)count;
    }

}