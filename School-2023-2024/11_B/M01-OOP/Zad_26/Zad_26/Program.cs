namespace Zad_26
{
    public class Program
    {
        private static ItemList items = new ItemList();
        public static void Main()
        {
            CreateItems();

            PrintItems();
        }

        private static void PrintItems()
        {
            Console.WriteLine($"Items: ");
            for (int i = 0; i < items.Count(); i++)
            {
                Console.WriteLine(items.Get(i));
            }
        }

        private static void CreateItems()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                items.Add(new Item(input[0], double.Parse(input[1])));
            }
        }
    }
}