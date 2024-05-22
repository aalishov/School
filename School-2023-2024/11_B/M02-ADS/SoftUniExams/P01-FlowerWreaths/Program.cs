using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
        Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
        int wreath = 0;
        int leftFlowers = 0;

        while (lilies.Count > 0 && roses.Count > 0)
        {
            int lily = lilies.Pop();
            int rose = roses.Dequeue();

            int sum = lily + rose;
            if (sum == 15)
            {
                wreath++;
            }

            else if (sum > 15)
            {
                while (sum > 15)
                {
                    lily -= 2;
                    sum -= 2;

                    if (sum == 15)
                    {
                        wreath++;
                    }
                    else if (sum < 15)
                    {
                        leftFlowers += sum;
                    }
                }

            }
            else
            {
                leftFlowers += sum;
            }
        }

        wreath += (leftFlowers / 15);

        if (wreath >= 5)
        {
            Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
        }
        else
        {
            Console.WriteLine($"You didn't make it, you need {5-wreath} wreaths more!");
        }
        

    }
}

