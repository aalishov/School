public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] sea = new char[n, n];
        int iS = 0;
        int jS = 0;
        int fish = 0;

        for (int i = 0; i < sea.GetLength(0); i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < sea.GetLength(1); j++)
            {
                sea[i, j] = line[j];
                if (sea[i, j] == 'S')
                {
                    iS = i;
                    jS = j;
                }
            }
        }
        while (true)
        {
            string cmd = Console.ReadLine().ToLower();
            sea[iS, jS] = '-';
            if (cmd == "up")
            {
                if (iS - 1 < 0)
                {
                    iS = n - 1;
                    if (char.IsDigit(sea[iS, jS]))
                    {
                        fish += int.Parse(sea[iS, jS].ToString());
                    }
                    else if (sea[iS, jS] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS, jS] = 'S';
                }
                else
                {
                    if (char.IsDigit(sea[iS-1, jS]))
                    {
                        fish += int.Parse(sea[iS, jS].ToString());
                    }
                    else if (sea[iS-1, jS] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS - 1, jS] = 'S';
                    iS--;
                }
            }
            else if (cmd == "down")
            {
                if (iS + 1 >= n)
                {
                    iS = 0; 
                    if (char.IsDigit(sea[iS, jS]))
                    {
                        fish += int.Parse(sea[iS, jS].ToString());
                    }
                    else if (sea[iS, jS] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS, jS] = 'S';
                }
                else
                {
                    if (char.IsDigit(sea[iS+1, jS]))
                    {
                        fish += int.Parse(sea[iS+1, jS].ToString());
                    }
                    else if (sea[iS+1, jS] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS + 1, jS] = 'S';
                    iS++;
                }
            }
            else if (cmd == "left")
            {
                if (jS - 1 < 0)
                {
                    jS = n - 1;
                    if (char.IsDigit(sea[iS, jS]))
                    {
                        fish += int.Parse(sea[iS, jS].ToString());
                    }
                    else if (sea[iS, jS] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS, jS] = 'S';
                }
                else
                {
                    if (char.IsDigit(sea[iS, jS-1]))
                    {
                        fish += int.Parse(sea[iS, jS].ToString());
                    }
                    else if (sea[iS, jS-1] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS, jS - 1] = 'S';
                    jS--;
                }
            }
            else if (cmd == "right")
            {
                if (jS + 1 >= n)
                {
                    jS = 0;
                    if (char.IsDigit(sea[iS, jS]))
                    {
                        fish += int.Parse(sea[iS, jS].ToString());
                    }
                    else if (sea[iS, jS] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS, jS] = 'S';
                }
                else
                {
                    if (char.IsDigit(sea[iS, jS+1]))
                    {
                        fish += int.Parse(sea[iS, jS].ToString());
                    }
                    else if (sea[iS, jS+1] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{n},{n}]");
                        break;
                    }
                    sea[iS, jS + 1] = 'S';
                    jS++;
                }
            }
            if (cmd == "collect the nets")
            {
                if (fish>=20)
                {
                    Console.WriteLine("Success! You managed to reach the quota!");
                }
                else if (fish < 20)
                {
                    Console.WriteLine("You didn't catch enough fish and didn't reach the quota!");
                    Console.WriteLine($"You need {20-fish} tons of fish more.");
                }
                if (fish>0)
                {
                    Console.WriteLine($"Amount of fish caught: {fish} tons.");
                }
                PrintMatrix(sea);
                break;
            }
        }
    }

    private static void PrintMatrix(char[,] sea)
    {
        for (int i = 0; i < sea.GetLength(0); i++)
        {
            for (int j = 0; j < sea.GetLength(1); j++)
            {
                Console.Write(sea[i, j]);
            }
            Console.WriteLine();
        }
    }
}

