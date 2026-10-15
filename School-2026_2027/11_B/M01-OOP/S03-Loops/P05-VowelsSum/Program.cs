using System;
public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int vowelsSum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            if (currentChar == 'a')
            {
                vowelsSum++;

            }
            else if (currentChar == 'e')
            {
                vowelsSum += 2;
            }
            else if (currentChar == 'i')
            {
                vowelsSum += 3;
            }
            else if (currentChar == 'o')
            {
                vowelsSum += 4;
            }
            else if (currentChar == 'u')
            {
                vowelsSum += 5;
            }



        }
        Console.WriteLine(vowelsSum);
    }
}

