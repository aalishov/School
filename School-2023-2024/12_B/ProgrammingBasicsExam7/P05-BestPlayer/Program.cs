public class Program
{
    public static void Main()
    {
        string name = string.Empty;
        string topPlayer=string.Empty;
        int topPlayerGoals = 0;
        while ((name =Console.ReadLine())!="END")
        {
            int goalsScored = int.Parse(Console.ReadLine());
            
            if (goalsScored>topPlayerGoals)
            {
                topPlayer = name;
                topPlayerGoals = goalsScored;
                if (goalsScored>=10)
                {
                    break;
                }
            }
        }
        Console.WriteLine($"{topPlayer} is the best player!");
        if (topPlayerGoals>=3)
        {
            Console.WriteLine($"He has scored {topPlayerGoals} goals and made a hat-trick !!!");
        }
        else
        {
            Console.WriteLine($"He has scored {topPlayerGoals} goals.");
        }
    }
}

