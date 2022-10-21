using System;


public class Program
{
    private static char[,] field;
    private static int currentRow = -1;
    private static int currentCol = -1;
    private static int firstSRow = -1;
    private static int firstSCol = -1;
    private static int secondSRow = -1;
    private static int secondSCol = -1;
    private static int points = 0;
    public static void Main()
    {
        ReadField();
        PrintField();
        while (true)
        {
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "up":
                    Up();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            PrintField();
        }
       //Console.WriteLine($"firstS{firstSRow}, {firstSCol}");
       //Console.WriteLine($"secondS{secondSRow}, {secondSCol}");
    }
    public static void Up()
    {
        int newRow = currentRow-1;
        if (newRow<0 || newRow>field.GetLength(0))
        {
            Console.WriteLine("Don't try to escape the playing field!");
            return;
        }
        char newPlace = field[newRow, currentCol];
        field[currentRow, currentCol] = '-';
        if (newPlace=='-')
        {
            currentRow = newRow;
            
        }
        else if (newPlace=='S')
        {
            field[firstSRow,firstSCol] = '-';
            field[secondSRow, secondSCol] = '-';
            if (newRow==firstSRow&&currentCol==firstSCol)
            {
                currentRow = secondSRow;
                currentCol = secondSCol;
            }
            else
            {
                currentRow = firstSRow;
                currentCol = firstSCol;
            }
            points -= 3;
        }
        else
        {
            int addPoints = int.Parse(field[newRow, currentCol].ToString());
            points += addPoints;
            currentRow = newRow;
        }
        field[currentRow, currentCol] = 'M';
    }
    public static void ReadField()
    {
        int n = int.Parse(Console.ReadLine());
        field = new char[n, n];
        for (int row = 0; row < field.GetLength(0); row++)
        {
            char[] rowElements = Console.ReadLine().ToCharArray();
            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = rowElements[col];
                if (field[row,col]=='M')
                {
                    currentRow = row;
                    currentCol = col;
                }
                else if (field[row, col] == 'S' && firstSRow==-1)
                {
                    firstSRow = row;
                    firstSCol = col;
                }
                else if (field[row, col] == 'S' && firstSRow != -1)
                {
                    secondSRow = row;
                    secondSCol = col;
                }
            }
        }
    }
    public static void PrintField()
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                Console.Write(field[row, col]);
            }
            Console.WriteLine();
        }
    }
}

