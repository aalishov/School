using System;
using System.Linq;
class Program
{
    static void Main()
    {
        //Четене на елементи на масив от един ред, разделени с запетая
        Console.WriteLine("Enter elements separated witsh space: ");
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        //Отпечатване на елементи на един ред, разделени с запетая и интервал
        Console.WriteLine(string.Join(", ",numbers));
    }
}

