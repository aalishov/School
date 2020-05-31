namespace Ex04_P05_FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Stack<int> box = new Stack<int>(ReadArrNums());

            int rackCapacity = int.Parse(Console.ReadLine());
            int countRack = 1;
            int currentRackValue = 0;

            while (box.Any())
            {
                int clothes = box.Peek();

                if (rackCapacity>=clothes+currentRackValue)
                {
                    currentRackValue += clothes;
                    box.Pop();
                }
                else
                {
                    countRack++;
                    currentRackValue = 0;
                }
            }

            Console.WriteLine(countRack);
        }

        private static int[] ReadArrNums()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
