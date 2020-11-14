using System;


class Program
{
    static void Main()
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();
        long n = long.Parse(Console.ReadLine());

        long numberCounter = 0;
        bool isGenerated = false;

        for (int i = 0; i <= 9; i++)
        {
            if (isGenerated)
            {
                break;
            }
            for (int j = 0; j <= 9; j++)
            {
                if (isGenerated)
                {
                    break;
                }
                for (int k = 0; k <= 9; k++)
                {
                    if (isGenerated)
                    {
                        break;
                    }
                    for (int l = 0; l <= 9; l++)
                    {
                        long sum = i + j + k + l;
                        long product = i * k-n;
                        if (sum == product)
                        {
                            numberCounter++;
                            Console.Write($"{start}{i}{j}{k}{l}{end} ");
                        }
                        if (numberCounter == n)
                        {
                            isGenerated = true;
                            break;
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}

