public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxDiff = 0;
        bool isDiff = false;

        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int previousSum = num1 + num2;

        for (int i = 0; i < n - 1; i++)
        {
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int currentSum = num1 + num2;

            if (currentSum != previousSum)
            {
                isDiff = true;
                if (Math.Abs(currentSum - previousSum) > maxDiff)
                {
                    maxDiff = Math.Abs(currentSum - previousSum);
                }
            }
            previousSum = currentSum;
        }
        if (isDiff)
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
        else
        {
            Console.WriteLine($"Yes, value={previousSum}");
        }
    }
}

