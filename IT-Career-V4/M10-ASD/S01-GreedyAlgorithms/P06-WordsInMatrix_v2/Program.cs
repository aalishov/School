using System;
using System.IO;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            char[,] newMatrix = ReadMatrixFromFile("table.txt");
            string[] words = ReadWordsFromFile("words.txt");
            PrintMatrix(newMatrix);
            Console.WriteLine(string.Join(" ", words));
            Console.WriteLine(new string('*', 10));
            foreach (var word in words)
            {
                if (Contains(newMatrix, word))
                {
                    Console.WriteLine(word);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static string[] ReadWordsFromFile(string fileName)
    {
        return File.ReadAllLines(fileName);
    }
    public static char[,] ReadMatrixFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        char[,] matrix = new char[lines.Length, lines[0].Length];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (lines[i].Length!=matrix.GetLength(1))
            {
                throw new ArgumentException("Invalid format: Matrix is not rectangular!");
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = lines[i][j];
            }
        }
        return matrix;
    }
    public static bool Contains(char[,] matrix, string word)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            char[] row = new char[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                row[j] = matrix[i, j];
            }
            string rowString = new string(row);
            string reversedString = new string(row.Reverse().ToArray());
            if (rowString.IndexOf(word) != -1 || reversedString.IndexOf(word) != -1)
            {
                return true;
            }
        }
        return false;
    }
    public static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

