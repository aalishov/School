public class Program
{
    public static void Main()
    {
        List<int> list = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .ToList();

        int number = list[0];
        int count = 1;

        int currentNumber = list[0];
        int currentCount = 1;

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] == currentNumber)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > count)
                {
                    number = currentNumber;
                    count = currentCount;
                }
                currentNumber = list[i];
                currentCount = 1;
            }
        }
        if (currentCount > count)
        {
            number = currentNumber;
            count = currentCount;
        }

        for (int i = 0; i < count; i++)
        {
            Console.Write(number + " ");
        }
    }
}

