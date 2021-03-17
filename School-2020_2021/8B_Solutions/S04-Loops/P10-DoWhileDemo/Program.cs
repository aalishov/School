using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        bool isNotZero = false;

        //Прави докато е вярно, цикъл със следусловие, задължително се зпълнява поне веднъж
        do
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number==0)
            {
                isNotZero = false;  
            }
            sum += number;
        } while (isNotZero);
        Console.WriteLine($"Sum: {sum}");
    }
}

