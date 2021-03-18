using System;


class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string str1 = words[0];
        string str2 = words[1];
        
        int sum = 0;

        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            sum += (str1[i]*str2[i]);
        }
        //a aaaa
        if (str1.Length>str2.Length)
        {
            for (int i = minLength; i < str1.Length; i++)
            {
                sum += str1[i];
            }
        }
        else if (str1.Length < str2.Length)
        {
            for (int i = minLength; i < str2.Length; i++)
            {
                sum += str2[i];
            }
        }
        Console.WriteLine(sum);
    }
}

