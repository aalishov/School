using System;

namespace P11_ConditionalStatementsSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Л - лице, О - обиколка");
            Console.Write("Въведи команда: ");
            string str = Console.ReadLine();

            switch (str)
            {

                case "Л":
                case "Лице":
                    Console.Write("Въведи страна: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Въведи височина: ");
                    int ha = int.Parse(Console.ReadLine());
                    int s = (a * ha) / 2;
                    Console.WriteLine($"Лицето на триъгълника е {s}");
                    break;
                case "О":
                case "Обиколка":
                    Console.Write("Въведи страна: ");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.Write("Въведи страна: ");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.Write("Въведи страна: ");
                    int a3 = int.Parse(Console.ReadLine());
                    int p = a1 + a2 + a3;
                    Console.WriteLine($"Обиколката на триъгълника е {p}");
                    break;
                default:
                    Console.WriteLine("Няма такава команда!");
                    break;
            }

        }
    }
}
