using System;

namespace P10_ConditionalStatemtnIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой точки: ");
            int points = int.Parse(Console.ReadLine());

            if (points >= 80)
            {
                Console.WriteLine("Отличен");
            }
            else if (points >= 60 && points < 80)
            {
                Console.WriteLine("Много добър");
            }
            else if (points >= 40 && points < 60)
            {
                Console.WriteLine("Добър");
            }
            else if (points >= 20 && points < 40)
            {
                Console.WriteLine("Среден");
            }
            else
            {
                Console.WriteLine("Слаб");
            }

        }
    }
}
