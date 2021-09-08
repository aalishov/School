using System;

class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            Console.WriteLine(firstNum);
        }
        else
        {
            Console.WriteLine(secondNum);
        }

        //Console.WriteLine(Math.Max(firstNum, secondNum));
    }
}

