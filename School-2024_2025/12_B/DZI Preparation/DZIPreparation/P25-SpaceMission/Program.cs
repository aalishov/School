using System;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] space = new char[n, n];
        int resources = 100;
        int shipJ = 0;
        int shipI = 0;

        int planetI = 0;
        int planetJ = 0;
        for (int i = 0; i < n; i++)
        {
            char[] line = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
            for (int j = 0; j < n; j++)
            {
                space[i, j] = line[j];
                if (space[i, j] == 'S')
                {
                    shipI = i;
                    shipJ = j;
                }
                else if (space[i, j] == 'P')
                {
                    planetI = i;
                    planetJ = j;
                }
            }
        }
        string cmd = string.Empty;
        try
        {
            while (true)
            {
                cmd = Console.ReadLine();
                resources -= 5;
                if (space[shipI, shipJ] != 'R')
                {
                    space[shipI, shipJ] = '.';
                }
                if (cmd == "right")
                {
                    shipJ++;
                }
                else if (cmd == "left")
                {
                    shipJ--;
                }
                else if (cmd == "up")
                {
                    shipI--;
                }
                else if (cmd == "down")
                {
                    shipI++;
                }
                if (space[shipI, shipJ] == 'R')
                {
                    if (resources + 10 <= 100)
                    {
                        resources += 10;
                    }
                    else
                    {
                        resources = 100;
                    }
                }
                else if (space[shipI, shipJ] == 'M')
                {
                    space[shipI, shipJ] = '.';
                    resources -= 5;
                }
                else if (space[shipI, shipJ] == 'P')
                {
                    break;
                }

                if (resources < 5)
                {
                    Console.WriteLine($"Mission failed! The spaceship was stranded in space.");
                    space[shipI, shipJ] = 'S';
                    PrintSpaceField(n, space);
                    Environment.Exit(0);
                }
            }
        }
        catch (Exception ex)
        {
            if (cmd == "right")
            {
                shipJ--;
            }
            else if (cmd == "left")
            {
                shipJ++;
            }
            else if (cmd == "up")
            {
                shipI++;
            }
            else if (cmd == "down")
            {
                shipI--;
            }
            space[shipI, shipJ] = 'S';
            Console.WriteLine("Mission failed! The spaceship was lost in space.");
            PrintSpaceField(n, space);
            Environment.Exit(0);
        }

        Console.WriteLine($"Mission accomplished! The spaceship reached Planet Eryndor with {resources} resources left.");

        PrintSpaceField(n, space);
    }

    private static void PrintSpaceField(int n, char[,] space)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{space[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

