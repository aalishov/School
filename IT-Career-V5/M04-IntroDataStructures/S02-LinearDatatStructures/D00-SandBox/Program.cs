public class Program
{
    private static int rowIndex = 0;
    private static int colIndex = 0;
    public static void Main()
    {
        char[,] field = new char[3, 3];

        Random random = new Random();

        CreateField(field);

        field[rowIndex, colIndex] = '*';
        PrintArray(field);
        while (true)
        {
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "right":
                    Right(field);
                    break;
                case "up":
                    Up(field);
                    break;
            }
            Console.WriteLine();
            PrintArray(field);
        }


    }
    public static void Right(char[,] field)
    {
        field[rowIndex, colIndex] = '-';
        if (colIndex + 1 >= field.GetLength(1))
        {
            colIndex = 0;
        }
        else
        {
            colIndex++;
        }
        field[rowIndex, colIndex] = '*';
    }
    public static void Up(char[,] field)
    {
        field[rowIndex, colIndex] = '-';
        if (rowIndex - 1 < 0)
        {
            rowIndex = field.GetLength(0)-1;
        }
        else
        {
            rowIndex--;
        }
        field[rowIndex, colIndex] = '*';
    }

    private static void CreateField(char[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = '-';
            }
        }
    }

    private static void PrintArray(char[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                Console.Write($"{field[row, col],2}");
            }
            Console.WriteLine();
        }
    }
}


//3 dimensional array
//public class Program
//{
//    public static void Main()
//    {
//        int[,,] field = new int[5, 5, 5];

//        Random random = new Random();

//        for (int row = 0; row < field.GetLength(0); row++)
//        {
//            for (int col = 0; col < field.GetLength(1); col++)
//            {
//                for (int depth = 0; depth < field.GetLength(2); depth++)
//                {
//                    field[row, col, depth] = random.Next(-50, 50);
//                }
//            }
//        }
//        for (int row = 0; row < field.GetLength(0); row++)
//        {
//            for (int col = 0; col < field.GetLength(1); col++)
//            {
//                for (int depth = 0; depth < field.GetLength(2); depth++)
//                {
//                    Console.Write($"{field[row, col, depth],6}");
//                }
//                Console.WriteLine($"=>");
//            }
//            Console.WriteLine($"\t=>");
//        }
//    }
//}
