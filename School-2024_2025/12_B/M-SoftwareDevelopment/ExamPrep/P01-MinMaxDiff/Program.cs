public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 5, 4, 6 };

        Console.WriteLine(FindLastEven(numbers));
    }
    public static int FindRange(int[] numbers)
    {
        int minNum = int.MaxValue;
        int maxNum = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if ( minNum > numbers[i] )
            {
                minNum = numbers[i];
            }
            if (numbers[i] > maxNum )
            {
                maxNum = numbers[i];
            }
        }
        return maxNum - minNum;
    }
    public static int FindLastEven(int[] numbers)
    {
        int evenNum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNum = numbers[i];
            }
            else
            {
                evenNum = -1;
            }
        }
        return evenNum;
    }
}

