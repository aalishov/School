public class Program
{
    static void Main()
	{
		ItemList_ itemList = new ItemList_();
		try
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] info = Console.ReadLine().Split(" ");
				itemList.Add(new Item(info[0], double.Parse(info[1])));
			}

			for (int i = 0; i < itemList.Count; i++)
			{
				Console.WriteLine(itemList.Get(i));
            }
		}
		catch (Exception ex )
		{
            Console.WriteLine(ex.Message);
        }
    }
}
