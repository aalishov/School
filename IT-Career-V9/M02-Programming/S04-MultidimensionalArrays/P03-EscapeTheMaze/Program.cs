public class Program
{
    private static char[,] maze;
    private static int startRow = 0;
    private static int startCol = 0;
    private static int health = 100;
    public static void Main()
    {
        CreateMaze();

        Action();
    }

    private static void Action()
    {
        while (true)
        {
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "left":
                    Left();
                    break;
                case "right":
                    Right();
                    break;
                case "up":
                    Up();
                    break;
                case "down":
                    Down();
                    break;
            }
            //Console.WriteLine();
            //PrintMaze();
            //Console.WriteLine($"Health: {health}");
        }
    }

    private static void Left()
    {
        if (startCol - 1 >= 0)
        {
            maze[startRow, startCol] = '-';
            startCol--;
            CheckPosition();
            maze[startRow, startCol] = 'P';
        }
    }

    private static void Right()
    {
        if (startCol + 1 < maze.GetLength(1))
        {
            maze[startRow, startCol] = '-';
            startCol++;
            CheckPosition();
            maze[startRow, startCol] = 'P';
        }
    }

    private static void Up()
    {
        if (startRow - 1 >= 0)
        {
            maze[startRow, startCol] = '-';
            startRow--;
            CheckPosition();
            maze[startRow, startCol] = 'P';
        }
    }

    private static void Down()
    {
        if (startRow + 1 < maze.GetLength(0))
        {
            maze[startRow, startCol] = '-';
            startRow++;
            CheckPosition();
            maze[startRow, startCol] = 'P';
        }
    }

    private static void CheckPosition()
    {
        if (maze[startRow, startCol] == 'M')
        {
            health -= 40;
            if (health <= 0)
            {
                Console.WriteLine("Player is dead. Maze over!");
                Console.WriteLine($"Player's health: 0 units");
                maze[startRow, startCol] = 'P';
                PrintMaze();
                Environment.Exit(0);
            }
        }
        else if (maze[startRow, startCol] == 'H')
        {
            health += 15;
            if (health > 100) { health = 100; }
        }
        else if (maze[startRow, startCol] == 'X')
        {
            Console.WriteLine($"Player escaped the maze. Danger passed!");
            Console.WriteLine($"Player's health: {health} units");
            maze[startRow, startCol] = 'P';
            PrintMaze();
            Environment.Exit(0);
        }
    }

    private static void PrintMaze()
    {
        for (int row = 0; row < maze.GetLength(0); row++)
        {
            for (int col = 0; col < maze.GetLength(1); col++)
            {
                Console.Write($"{maze[row, col]}");
            }
            Console.WriteLine();
        }
    }

    private static void CreateMaze()
    {
        int n = int.Parse(Console.ReadLine());
        maze = new char[n, n];

        for (int row = 0; row < maze.GetLength(0); row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < maze.GetLength(1); col++)
            {
                maze[row, col] = line[col];
                if (maze[row, col] == 'P')
                {
                    startRow = row;
                    startCol = col;
                }
            }
        }
    }
}

