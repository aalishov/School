using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string input = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\08_B\\S01-ProgrammingBasics\\P32-File\\input.txt";

        using (StreamReader reader = new StreamReader(input))
        {
            int sum = 0;
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                sum += int.Parse(line);
                Console.WriteLine(line);
            }
            Console.WriteLine($"Sum: {sum}");
        }

        using (StreamWriter writer = new StreamWriter(input,true))
        {
            Console.Write("Enter nums count: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                int number=int.Parse(Console.ReadLine());

                writer.WriteLine(number);
            }
        }
    }
}

