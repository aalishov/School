
public class Program
{
    static char[][] field;
    static int heroRowIndex = 0;
    static int heroColIndex = 0;
    public static void Main()
    {
        int rows = 5; //int.Parse(Console.ReadLine());
        CreateField(rows);
        

        field[heroRowIndex][heroColIndex] = '@';
        PrintField();

        while (true)
        {
            string cmd=Console.ReadLine();
            switch (cmd)
            {
                case "right":
                    MoveRight();
                    break;
                default:
                    return;
            }
            Console.Clear();
            PrintField();
        }

        
    }

    private static void MoveRight()
    {
        heroColIndex++;
        field[heroRowIndex][heroColIndex] = '@';
        field[heroRowIndex][heroColIndex - 1] = '-';
    }
    private static void MoveLeft()
    {
        heroColIndex--;
        field[heroRowIndex][heroColIndex] = '@';
        field[heroRowIndex][heroColIndex + 1] = '-';
    }

    private static void PrintField()
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            Console.WriteLine(string.Join(" ", field[i]));
        }
    }

    private static void CreateField(int rows)
    {
        field = new char[rows][];

        for (int i = 0; i < rows; i++)
        {
            field[i] = new string('-', rows).ToCharArray();
        }
    }
}

