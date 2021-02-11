using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> cmd = new List<string>();

        string input = "L20R10LL20R10R30";

        string number = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
            {
                if (number != string.Empty)
                {
                    cmd.Add(number);
                    number = string.Empty;
                }
                cmd.Add(input[i].ToString());
            }
            else if (char.IsDigit(input[i]))
            {
                number += input[i];
                if (i == input.Length - 1)
                {
                    cmd.Add(number);
                }
            }
        }

        Console.WriteLine(string.Join(" ", cmd));
    }
}

