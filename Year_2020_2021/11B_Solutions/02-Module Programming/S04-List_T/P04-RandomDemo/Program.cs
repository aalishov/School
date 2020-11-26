using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> numbers1 = new List<int>();
        //Генерира различни числа
        for (int i = 1; i <= 20; i++)
        {
            Random random = new Random();
            Thread.Sleep(20);
            numbers.Add(random.Next(18, 75));
        }
        //Генерира еднакви числа
        for (int i = 1; i <= 20; i++)
        {
            Random random = new Random();
            numbers1.Add(random.Next(18, 75));
        }

        Console.WriteLine(string.Join(", ",numbers));
        Console.WriteLine(string.Join(", ", numbers1));
    }
}

