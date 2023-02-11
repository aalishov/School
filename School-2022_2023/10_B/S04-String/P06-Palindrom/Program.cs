using System;

public class Program
{
    public static void Main(string[] args)
    {
        string s = "baba";

        bool isTrue=true;

        for (int i = 0; i < s.Length/2; i++)
        {
            char left =s[i];
            char right = s[s.Length - 1-i];
            if (left!=right)
            {
                isTrue= false;
            }
        }
        Console.WriteLine(isTrue);
    }
}

