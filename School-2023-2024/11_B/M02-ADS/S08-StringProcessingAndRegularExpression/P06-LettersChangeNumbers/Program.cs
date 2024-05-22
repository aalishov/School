public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        double result = 0.0;

        foreach (string word in input)
        {
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            double number = double.Parse(word.Substring(1, word.Length - 2));

            if (char.IsUpper(firstLetter))
            {
                number /= GetPosition(firstLetter);
            }
            else if (char.IsLower(firstLetter))
            {
                number *= GetPosition(firstLetter);
            }

            if (char.IsUpper(lastLetter))
            {
                number -= GetPosition(lastLetter);
            }
            else if (char.IsLower(lastLetter))
            {
                number += GetPosition(lastLetter);
            }
            result += number;
        }

        Console.WriteLine($"{result:f2}");
    }

    public static int GetPosition(char letter)
    {
        if (char.IsUpper(letter))
        {
            return letter - 64;
        }
        else if (char.IsLower(letter))
        {
            return letter - 96;
        }
        return 0;
    }
}

