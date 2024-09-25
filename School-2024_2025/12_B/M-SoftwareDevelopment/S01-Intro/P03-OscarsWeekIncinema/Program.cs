
public class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string type = Console.ReadLine();
        int tickets = int.Parse(Console.ReadLine());
        double sum = 0;

        if(name == "A Star Is Born")
        {
            if (type == "normal")
            {
                sum = 7.50 * tickets;
            }
            else if(type == "luxury")
            {
                sum = 10.50 * tickets;
            }
            else if (type == "ultra luxury")
            {
                sum = 13.50 * tickets;
            }
        }
        else if (name == "Bohemian Rhapsody")
        {
            if (type == "normal")
            {
                sum = 7.35 * tickets;
            }
            else if (type == "luxury")
            {
                sum = 9.45 * tickets;
            }
            else if (type == "ultra luxury")
            {
                sum = 12.75 * tickets;
            }
        }
        else if (name == "Green Book")
        {
            if (type == "normal")
            {
                sum = 8.15 * tickets;
            }
            else if (type == "luxury")
            {
                sum = 10.25 * tickets;
            }
            else if (type == "ultra luxury")
            {
                sum = 13.25 * tickets;
            }
        }
        else if (name == "The Favourite")
        {
            if (type == "normal")
            {
                sum = 8.75 * tickets;
            }
            else if (type == "luxury")
            {
                sum = 11.55 * tickets;
            }
            else if (type == "ultra luxury")
            {
                sum = 13.95 * tickets;
            }
        }
        Console.WriteLine($"{name} -> {sum:f2} lv.");
    }
}

