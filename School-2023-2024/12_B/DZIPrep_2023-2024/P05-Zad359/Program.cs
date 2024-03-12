public class Program
{
    public static void Main()
    {
        string pathInput = @"C:\Users\aalis\Desktop\Trash\Exam\P02-zad359\Input.txt";
        string pathOutput = @"C:\Users\aalis\Desktop\Trash\Exam\P02-zad359\Output.txt";

        string[] lines = File.ReadAllLines(pathInput);
        string[] result = new string[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            string[] names = lines[i].Split(" ");
            string name = $"{names[0][0]}. {names[1][0]}. {names[2]}";
            result[i] = name;
        }
        Console.WriteLine(string.Join(Environment.NewLine, result));

        File.AppendAllLines(pathOutput, result);
    }
}

