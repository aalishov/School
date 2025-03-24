public class Program
{
    public static void Main()
    {
        try
        {
            string table = "table.txt";
            string wordsFileName = "words.txt";

            char[,] matrix = ReadMatrix(table);

            PrintMatrix(matrix);

            List<string> words = ReadWords(wordsFileName);

            foreach (var item in words)
            {
                if (Contains(matrix, item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static bool Contains(char[,] matrix, string check)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            char[] wordArray = new char[matrix.GetLength(1)];
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                wordArray[cols] = matrix[rows, cols];
            }
            string word = new string(wordArray);
            if (word.IndexOf(check) != -1)
            {
                return true;
            }
            //wordArray = wordArray.Reverse().ToArray();
            Array.Reverse(wordArray);
            word = new string(wordArray);
            if (word.IndexOf(check) != -1)
            {
                return true;
            }
        }
        return false;
    }

    private static List<string> ReadWords(string wordsFileName)
    {
        return File.ReadAllLines(wordsFileName).ToList();
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write($"{matrix[rows, cols],2} "); ;
            }
            Console.WriteLine();
        }
    }

    private static char[,] ReadMatrix(string table)
    {
        string[] matrixLines = File.ReadAllLines(table);
        int firstLineLength = matrixLines[0].Length;
        if (matrixLines.Any(x => x.Length != firstLineLength))
        {
            throw new InvalidOperationException("Invalid matrix");
        }
        char[,] matrix = new char[matrixLines.Length, firstLineLength];
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            char[] word = matrixLines[rows].ToCharArray();
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = word[cols];
            }
        }
        return matrix;
    }
}