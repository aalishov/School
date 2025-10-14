public class Program
{
    public static void Main()
    {
        Console.Write("Enter field size: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter start position (row index): ");
        int rowPosition = int.Parse(Console.ReadLine());
        Console.Write("Enter start position (col index): ");
        int colPosition = int.Parse(Console.ReadLine());

        char[,] field = new char[n, n];
        CreateField(field);
        SetStartPositon(rowPosition, colPosition, field);
        PrintField(field);
        while (true)
        {
            Console.Write("Enter up/down/left/right: ");
            string cmd = Console.ReadLine();


            field[rowPosition, colPosition] = '-';
            switch (cmd)
            {
                case "up":
                    if (rowPosition - 1 >= 0)
                    {
                        rowPosition--;
                    }
                    break;
                case "down":
                    if (rowPosition + 1 < field.GetLength(0))
                    {
                        rowPosition++;
                    }
                    break;
                case "left":
                    colPosition = MoveLeft(colPosition, field);
                    break;
                case "right":
                    colPosition = MoveRight(colPosition, field);
                    break;
                default:
                    break;
            }
            field[rowPosition, colPosition] = '*';
            Console.Clear();
            PrintField(field);
        }
    }

    private static int MoveLeft(int colPosition, char[,] field)
    {
        if (colPosition - 1 >= 0)
        {
            colPosition--;
        }
        else
        {
            colPosition = field.GetLength(1) - 1;
        }

        return colPosition;
    }

    private static int MoveRight(int colPosition, char[,] field)
    {
        if (colPosition + 1 < field.GetLength(1))
        {
            colPosition++;
        }
        else
        {
            colPosition = 0;
        }

        return colPosition;
    }

    private static void SetStartPositon(int rowPosition, int colPosition, char[,] field)
    {
        field[rowPosition, colPosition] = '*';
    }

    private static void PrintField(char[,] field)
    {
        for (int rows = 0; rows < field.GetLength(0); rows++)
        {
            for (int cols = 0; cols < field.GetLength(1); cols++)
            {
                Console.Write($"{field[rows, cols]} "); ;
            }
            Console.WriteLine();
        }
    }

    private static void CreateField(char[,] field)
    {
        for (int rows = 0; rows < field.GetLength(0); rows++)
        {
            for (int cols = 0; cols < field.GetLength(1); cols++)
            {
                field[rows, cols] = '-';
            }
        }
    }
}