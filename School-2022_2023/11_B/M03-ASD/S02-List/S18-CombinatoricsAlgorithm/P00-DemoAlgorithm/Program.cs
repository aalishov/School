using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Въведете число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Разбивания на числото:");
        Разбиване_на_число(n, "", 1);
    }

    static void Разбиване_на_число(int n, string разбиване, int start)
    {
        if (n == 0)
        {
            Console.WriteLine(разбиване.TrimEnd('+'));
            return;
        }

        for (int i = start; i <= n; i++)
        {
            Разбиване_на_число(n - i, разбиване + i + "+", i);
        }
    }
}
