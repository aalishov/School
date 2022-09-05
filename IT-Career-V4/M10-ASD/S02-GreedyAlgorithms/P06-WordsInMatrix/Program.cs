using System;
using System.IO;
using System.Linq;

//Задача №28 от ДЗИ по Информатика на 26/08/2022
public class Program
{
    static void Main()
    {
        try
        {
            char[][] newMatrix = ReadMatrixFromFile("table.txt");
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
    public static bool Contains(char[][] matrix, string word)
    {
        foreach (var row in matrix)
        {
            string rowString = new string(row);
            string reversedString = new string(row.Reverse().ToArray());
            if (rowString.IndexOf(word) != -1 || reversedString.IndexOf(word) != -1)
            {
                return true;
            }
        }
        return false;
    }

    public static char[][] ReadMatrixFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        char[][] matrix = new char[lines.Length][];

        int colCount = lines[0].Length;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string item = lines[i];
            if (item.Length != colCount)
            {
                throw new ArgumentException("Invalid format: Matrix is not rectangular!");
            }
            matrix[i] = item.ToCharArray();
        }
        return matrix;
    }

    public static void PrintMatrix(char[][] matrix)
    {
        foreach (var item in matrix)
        {
            Console.WriteLine(String.Join(" ",item));
        }
    }
}

