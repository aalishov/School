using System.Xml.Linq;

public class Program
{
    private static int[] array;
    static void Main()
    {
        array = ReadArray();
        Console.Write("Enter k:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum of the elements greater than {k}: {GreaterThan(k)}");
        Console.WriteLine($"Count of the elements that are even: {SumOfDigit()}");
    }
    public static int SumOfDigit()
    {
        
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            if (array[i] >= 100 && array[i] <= 999)
            {
                while (array[i] > 0)
                {
                    int digit = array[i] % 10;
                    sum += digit;
                    array[i] /= 10;
                }
                if (sum%2==0)
                {
                    count++;
                }
            }
        }
        return count;
    }
    public static int GreaterThan(int k)
    {
        return array.Where(x => x > k).Sum();
    }
    private static int[] ReadArray()
    {
        Console.WriteLine("Enter length of the array:");
        int[] array = new int[ReadLength(2, 50)];
        Console.WriteLine("Enter  elements of the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    public static int ReadLength(int min, int max)
    {
        int size = int.Parse(Console.ReadLine());
        while (true)
        {
            if (size >= min && size <= max)
            {
                return size;
            }
            return -1;
        }
    }
}
