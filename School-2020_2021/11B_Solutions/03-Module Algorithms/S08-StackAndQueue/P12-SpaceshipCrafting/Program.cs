namespace P12_SpaceshipCrafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        private static Queue<int> liquids = new Queue<int>(ReadArr());
        private static Stack<int> items = new Stack<int>(ReadArr());
        private static int aluminium = 0;
        private static int glass = 0;
        private static int lithium = 0;
        private static int fiber = 0;
        public static void Main()
        {
            Crafting();

            Output();
        }

        private static void Crafting()
        {
            while (true)
            {
                if (!(liquids.Any() && items.Any()))
                {
                    break;
                }
                int currentLiquids = liquids.Dequeue();
                int currentItem = items.Pop();
                int sum = currentLiquids + currentItem;
                switch (sum)
                {
                    case 25:
                        glass++;
                        break;
                    case 50:
                        aluminium++;
                        break;
                    case 75:
                        lithium++;
                        break;
                    case 100:
                        fiber++;
                        break;
                    default:
                        currentItem += 3;
                        items.Push(currentItem);
                        break;
                }
            }
        }
        private static void Output()
        {
            if (glass > 0 && aluminium > 0 && lithium > 0 && fiber > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (items.Any())
            {
                Console.WriteLine($"Items left: {string.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine("Items left: none");
            }
            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {fiber}");
            Console.WriteLine($"Glass: {glass}");
            Console.WriteLine($"Lithium: {lithium}");
        }
        public static int[] ReadArr()
        {
            return Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        }
    }
}
