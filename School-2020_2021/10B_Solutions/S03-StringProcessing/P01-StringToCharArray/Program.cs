using System;


public class Program
{
    public static void Main()
    {
        string word = "Hello, C#!";

        char[] charArray = word.ToCharArray();

        for (int i = 0; i <charArray.Length; i++)
        {
            if (char.IsDigit(charArray[i]))
            {
                Console.WriteLine($"{charArray[i]} - digit");
            }
            else if (char.IsLetter(charArray[i]))
            {
                if (char.IsUpper(charArray[i]))
                {
                    Console.WriteLine($"{charArray[i]} - upper letter");
                }
                else
                {
                    Console.WriteLine($"{charArray[i]} - lower letter");
                }
            }
            else if (char.IsWhiteSpace(charArray[i]))
            {
                Console.WriteLine($"{charArray[i]} - white space");
            }
            else
            {
                Console.WriteLine($"{charArray[i]} - separator");
            }
        }
    }
}

