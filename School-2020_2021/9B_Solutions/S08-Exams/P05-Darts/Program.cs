using System;

class Program
{
    static string name = string.Empty;
    static int myPoints = 301;
    static int successful = 0;
    static int unsuccessful = 0;
    static void Main()
    {
        Input();

        Action();

        Output();
    }

    private static void Output()
    {
        if (myPoints == 0)
        {
            Console.WriteLine($"{name} won the leg with {successful} shots.");
        }
        else
        {
            Console.WriteLine($"{name} retired after {unsuccessful} unsuccessful shots.");
        }
    }

    private static void Action()
    {
        while (myPoints != 0)
        {
            string field = Console.ReadLine();

            if (field == "Retire")
            {
                break;
            }
            int points = int.Parse(Console.ReadLine());
            switch (field)
            {
                case "Single":
                    break;
                case "Double":
                    points *= 2;
                    break;
                case "Triple":
                    points *= 3;
                    break;
            }
            if (myPoints >= points)
            {
                myPoints -= points;
                successful++;
            }
            else
            {
                unsuccessful++;
            }
        }
    }

    public static void Input()
    {
        name = Console.ReadLine();
    }
}

