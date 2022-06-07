public class Program
{
    public static void Main()
    {
        Item item5 = new Item("Drink", 3);
        Item item1 = new Item("Food", 1);
        Item item2 = new Item("Food", 2);
        Item item3 = new Item("Food", 0.5);
        Item item4 = new Item("Drink", 4);
        Item item6 = new Item("Drink", 4);
        ItemList itemList = new ItemList();
        itemList.Add(item1);
        itemList.Add(item2);
        itemList.Add(item3);
        itemList.Add(item5);
        itemList.Add(item4);
        Console.WriteLine(itemList.ToString());
    }
}

