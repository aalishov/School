
public class Program
{
    private static int wreathsCount = 0;
    private static int storedFlowers = 0;
    private static Stack<int> lilies;
    private static Queue<int> roses;
    public static void Main()
    {
        Input();
        Action();
        Output();
    }

    private static void Input()
    {
        lilies = new Stack<int>(ReadFlowers());
        roses = new Queue<int>(ReadFlowers());
    }

    private static void Action()
    {
        while (lilies.Count != 0 && roses.Count != 0)
        {
            int lilly = lilies.Pop();
            int rose = roses.Dequeue();
            int sum = lilly + rose;
            if (sum == 15)
            {
                wreathsCount++;
            }
            else if (sum > 15)
            {
                while (sum > 15)
                {
                    sum -= 2;
                }
                if (sum == 15)
                {
                    wreathsCount++;
                }
                else
                {
                    storedFlowers += sum;
                }

            }
            else
            {
                storedFlowers += sum;
            }
        }
        wreathsCount += (storedFlowers / 15);
    }

    private static void Output()
    {
        if (wreathsCount >= 5)
        {
            Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
        }
        else
        {
            Console.WriteLine($"You didn't make it, you need {5 - wreathsCount} wreaths more!");
        }
    }

    private static IEnumerable<int> ReadFlowers()
    {
        return Console.ReadLine().Split(", ").Select(int.Parse);
    }
}

