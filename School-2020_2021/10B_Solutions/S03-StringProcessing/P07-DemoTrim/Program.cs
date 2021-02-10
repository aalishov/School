using System;


class Program
{
    static void Main()
    {
        string input = "     string     ";
        Console.WriteLine(input);
        
        string trimRisult = input.Trim();
        string risultTrim = trimRisult.Replace(" ", "_");
        Console.WriteLine(risultTrim);

        string trimEndRisult = input.TrimEnd();
        string risultTrimEnd = trimEndRisult.Replace(" ", "_");
        Console.WriteLine(risultTrimEnd);

        string trimStartRisult = input.TrimStart();
        string risultTrimStart = trimStartRisult.Replace(" ", "_");
        Console.WriteLine(risultTrimStart);
    }
}

