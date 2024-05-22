
public class Program
{
    public static void Main()
    {

        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int maxSum = int.MinValue;
        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int maxStart = 0;
        int maxEnd = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (sum < 0)
            {
                startIndex = i;
                endIndex = i;
                sum = 0;
            }

            sum += input[i];
            endIndex = i;

            if (sum > maxSum)
            {
                maxStart = startIndex;
                maxEnd = endIndex;
                maxSum = sum;
            }
            else if (sum == maxSum && ((endIndex - startIndex) > (maxEnd - maxStart)))
            {
                maxStart = startIndex;
                maxEnd = endIndex;
            }
        }

        Console.WriteLine($"{maxSum} {maxStart} {maxEnd}");
    }
}