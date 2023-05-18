using System;

public class Program
{
    public static void Main(string[] args)
    {
        ItemList list= new ItemList();

        Console.Write("Enter items count: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.Write("Enter d: ");
                string description=Console.ReadLine();
                Console.Write("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                list.Add(new Item(description,price));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

