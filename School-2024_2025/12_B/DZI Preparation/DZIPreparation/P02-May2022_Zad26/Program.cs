public class Program
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        ItemList items = new ItemList();

        for (int i = 0; i < n; i++)
        {
            try
            {
                string description = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                items.Add(new Item(description, price));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                i--;
            }
        }

        Console.WriteLine(items);
    }
}

