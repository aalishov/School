public class Program
{
    public static void Main()
    {
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
        phoneBook.Add("Bob", "987-654-3210");
        phoneBook.Add("Charlie", "555-555-5555");
        phoneBook.Add("Alice", "123-456-7890");

        Console.WriteLine(phoneBook["Bob"]);
        phoneBook["Bob"] = "111-222-3333";
        Console.WriteLine(phoneBook["Bob"]);
        if (!phoneBook.ContainsKey("Bob"))
        {
            phoneBook.Add("Bob", "444-444-4444");
        }
        Console.WriteLine(phoneBook.Remove("Charlie"));
        phoneBook.Add("Charlie", "555-555-5555");
        foreach (var entry in phoneBook)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}

