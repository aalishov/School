public class Program
{
    public static void Main()
    {
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
        phoneBook.Add("John", "+3595555");
        if (phoneBook.ContainsKey("John"))
        {
            phoneBook["John"] = "+35947777";
        }

        phoneBook.Add("Alex", "+3595225");
        phoneBook.Add("Jane", "+3599875");

        foreach (var kvp in phoneBook)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}