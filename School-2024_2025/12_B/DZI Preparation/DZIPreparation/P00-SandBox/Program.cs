static int[,] ReadMatrix(int n)
{
    int[,] matrix = new int[n, n];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            matrix[rows, cols] = new Random().Next(10, 99);
        }
    }
    return matrix;
}

static void PrintMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            if (rows+cols==matrix.GetLength(0)-1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matrix[rows, cols] + "  ");
            }
          else  if (rows > cols )
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(matrix[rows, cols] + "  ");
            }
           else if (rows < cols)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(matrix[rows, cols] + "  ");
            }
          else  
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(matrix[rows, cols] + "  ");
            }
        }
        Console.WriteLine();
    }
}

int[,] matrix = ReadMatrix(3);

PrintMatrix(matrix);