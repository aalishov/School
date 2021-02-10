using System;

class Program
{
    //Преминаване към главни и малки букви
    static void Main()
    {
        string town = "Velingrad";

        Console.WriteLine(town.ToUpper());

        //string day = "MoNdAy".ToLower();
        string day = "MoNdAy".ToLower();
        Console.WriteLine(day.ToLower());

        string readLine = Console.ReadLine().ToUpper();
        Console.WriteLine(readLine);
    }
}

