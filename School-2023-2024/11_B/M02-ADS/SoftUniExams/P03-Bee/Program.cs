public class Program
{
    private static char[][] field;

    static int beeRowIndex;
    static int beeColIndex;
    static int bonusRowIndex;
    static int bonusColIndex;
    public static void Main()
    {
        CreateField();

        PrintField();

        while (true)
        {
            Move cmd = Enum.Parse<Move>(Console.ReadLine());

            field[beeRowIndex][beeColIndex] = '-';
            switch (cmd)
            {
                case Move.up:
                    beeRowIndex--;
                    break;
                case Move.down:
                    beeRowIndex++;
                    break;
                case Move.left:
                    beeColIndex--;
                    break;
                case Move.right:
                    beeColIndex++;
                    break;
            }
            field[beeRowIndex][beeColIndex] = 'B';
            PrintField();
        }

        Console.WriteLine($"Bee position [{beeRowIndex}; {beeColIndex}]");
        Console.WriteLine($"Bee position [{bonusRowIndex}; {bonusColIndex}]");
    }

    private static void CreateField()
    {
        int size = int.Parse(Console.ReadLine());
        field = new char[size][];

        for (int i = 0; i < field.Length; i++)
        {
            field[i] = Console.ReadLine().ToCharArray();
            for (int j = 0; j < field[i].Length; j++)
            {
                if (field[i][j] == 'B')
                {
                    beeRowIndex = i;
                    beeColIndex = j;
                }
                else if (field[i][j] == 'O')
                {
                    bonusRowIndex = i;
                    bonusColIndex = j;
                }
            }
        }
    }

    private static void PrintField()
    {
        for (int i = 0; i < field.Length; i++)
        {
            Console.WriteLine(string.Join(" ", field[i]));
        }
    }

    public enum Move
    {
        left = 0, right = 1, up = 2, down = 3
    }
}

