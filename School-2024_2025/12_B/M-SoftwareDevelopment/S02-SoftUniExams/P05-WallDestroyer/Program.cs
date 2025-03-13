public class Program
{
    private static char[][] wall = null;
    private static int rowVanko = -1;
    private static int colVanko = -1;
    private static int hitRod = 0;
    private static int holes = 1;
    public static void Main()
    {
        CreateWall();

        FindVanko();

        string cmd = null;

        while ((cmd = Console.ReadLine()) != "End")
        {

            switch (cmd)
            {
                case "left":
                    if (colVanko - 1 >= 0)
                    {
                        wall[rowVanko][colVanko] = '*';
                        colVanko--;
                        if (wall[rowVanko][colVanko] == 'C')
                        {
                            wall[rowVanko][colVanko] = 'E';
                            return;
                        }
                        else if (wall[rowVanko][colVanko] == 'R')
                        {
                            hitRod++;
                            colVanko++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if(wall[rowVanko][colVanko] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{rowVanko}, {colVanko}]!");
                            colVanko++;
                        }
                        else
                        {
                            holes++;
                        }
                        wall[rowVanko][colVanko] = 'V';
                    }
                    break;
                case "right":
                    if (colVanko + 1 < wall.Length)
                    {
                        wall[rowVanko][colVanko] = '*';
                        colVanko++;
                        if (wall[rowVanko][colVanko] == 'C')
                        {
                            wall[rowVanko][colVanko] = 'E';
                            return;
                        }
                        else if (wall[rowVanko][colVanko] == 'R')
                        {
                            hitRod++;
                            colVanko--;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else
                        {
                            holes++;
                        }
                        wall[rowVanko][colVanko] = 'V';
                    }
                    break;
                case "up":
                    if (rowVanko - 1 >= 0)
                    {
                        wall[rowVanko][colVanko] = '*';
                        rowVanko--;
                        if (wall[rowVanko][colVanko] == 'C')
                        {
                            wall[rowVanko][colVanko] = 'E';
                            return;
                        }
                        else if (wall[rowVanko][colVanko] == 'R')
                        {
                            hitRod++;
                            rowVanko++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else
                        {
                            holes++;
                        }
                        wall[rowVanko][colVanko] = 'V';
                    }
                    break;
                case "down":
                    if (rowVanko + 1 < wall.Length)
                    {
                        wall[rowVanko][colVanko] = '*';
                        rowVanko++;
                        if (wall[rowVanko][colVanko] == 'C')
                        {
                            wall[rowVanko][colVanko] = 'E';
                            return;
                        }
                        else if (wall[rowVanko][colVanko] == 'R')
                        {
                            hitRod++;
                            rowVanko--;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else
                        {
                            holes++;
                        }
                        wall[rowVanko][colVanko] = 'V';
                    }
                    break;
            }
            Console.WriteLine();
            PrintWall();
        }

        if (wall[rowVanko][colVanko]!='E')
        {
            Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rowVanko} rod(s).");
        }
        else
        {
            holes++;
            Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
        }

    }
    private static void FindVanko()
    {
        for (int i = 0; i < wall.Length; i++)
        {
            for (int j = 0; j < wall[i].Length; j++)
            {
                if (wall[i][j] == 'V')
                {
                    rowVanko = i;
                    colVanko = j;
                    return;
                }
            }
        }
    }

    private static void PrintWall()
    {
        for (int i = 0; i < wall.Length; i++)
        {
            Console.WriteLine(string.Join("", wall[i]));
        }
    }

    private static void CreateWall()
    {
        int n = int.Parse(Console.ReadLine());
        wall = new char[n][];
        for (int i = 0; i < n; i++)
        {
            wall[i] = Console.ReadLine().ToCharArray();
        }
    }
}

