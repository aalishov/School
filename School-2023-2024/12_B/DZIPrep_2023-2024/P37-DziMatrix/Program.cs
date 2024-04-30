using System.Globalization;

public class Program
{
    private static char[][] matrix;
    public static void Main()
    {
        try
        {
            ReadMatrix("matrix.txt");
            string[] words = ReadWords("words.txt");
            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (Contains(matrix, words[i])) { result.Add(words[i]); }
            }

            File.WriteAllLines("output.txt",result.ToArray());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static bool Contains(char[][] matrix, string word)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            string current = new string(matrix[i]);
            if (current.IndexOf(word) != -1) { return true; }
            Array.Reverse(matrix[i]);
            current = new string(matrix[i]);
            if (current.IndexOf(word) != -1) { return true; }
        }
        return false;
    }

    public static string[] ReadWords(string path)
    {
        return File.ReadAllLines(path);
    }
    public static void ReadMatrix(string path)
    {
        string[] fileData = File.ReadAllLines(path);

        int rowLength = fileData.FirstOrDefault().Length;

        matrix = new char[fileData.Length][];

        for (int i = 0; i < fileData.Length; i++)
        {
            if (fileData[i].Length != rowLength) { throw new InvalidOperationException("Invalid format: Matrix is not rectangular!"); }
            matrix[i] = fileData[i].ToCharArray();
        }
    }
}