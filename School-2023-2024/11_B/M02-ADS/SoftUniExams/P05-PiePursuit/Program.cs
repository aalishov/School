using System.Collections;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Queue<int> people = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
        Stack<int> pies = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
        while (people.Count > 0 && pies.Count>0)
        {
            int lastPerson = people.Dequeue();
            int firstPie = pies.Pop();
            if (lastPerson >= firstPie)
            {
                lastPerson -= firstPie;
                if (lastPerson > 0)
                {
                    people.Enqueue(lastPerson);
                }
            }
            else
            {
                if (firstPie - lastPerson==1)
                {
                    if (pies.Count >= 1)
                    {
                        int last = pies.Pop();
                        pies.Push(last + 1);
                    }
                    else
                    {
                        pies.Push(1);
                    }

                }
                else
                {
                    pies.Push(firstPie - lastPerson);
                }
            }
        }
        if (pies.Count==0 && people.Count>0)
        {
            Console.WriteLine($"We will have to wait for more pies to be baked! \nContestants left: {string.Join(" ",people)}");
        }
        else if (pies.Count == 0 && people.Count == 0)
        {
            Console.WriteLine($"We have a champion!");
        }
        else
        {
            Console.WriteLine($"Our contestants need to rest! \nPies left: {string.Join(" ", pies)}");
        }
    }
}