public class Program
{
    private static int[] array;
    public static void Main()
    {
        array = ReadArray();
        Console.Write("Enter k:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"Multiplation: {Prod(k)}");
        Console.WriteLine($"Count of elements that are devisible by 3: {SumOfDigit()}");
    }
    public static int SumOfDigit()
    {

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            if (array[i] >= 100 && array[i] <= 666)
            {
                while (array[i] > 0)
                {
                    int digit = array[i] % 10;
                    sum += digit;
                    array[i] /= 10;
                }
                if (sum % 3 == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }
    private static int Prod(int k)
    {
        int multiplation = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i]<k)
            {
                multiplation *= array[i];
            }
        }
        return multiplation;    
    }
    private static int[] ReadArray()
    {
        Console.WriteLine("Enter length of the array:");
        int[] array = new int[ReadLength(2, 25)];
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
