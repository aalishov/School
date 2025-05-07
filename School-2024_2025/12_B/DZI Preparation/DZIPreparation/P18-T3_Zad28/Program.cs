public class Program
{
    private static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
    public static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter command [A]dd, [R]emove, [S]earch, [U]pdate, [P]rint: ");
                string cmd = Console.ReadLine().ToUpper();
                switch (cmd)
                {
                    case "A":
                    case "ADD":
                        Add();
                        break;
                    case "R":
                    case "REMOVE":
                        Remove();
                        break;
                    case "S":
                        Search();
                        break;
                    case "U":
                        Update();
                        break;
                    case "P":
                        Print();
                        break;
                    case "END":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not supported command!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public static void Add()
    {
        Console.Write("Enter name and phone number [Name, +35900000]: ");
        string[] input = Console.ReadLine().Split(", ");
        string name = input[0];
        string phone = input[1];
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine("Already exist!");
        }
        else
        {
            phoneBook.Add(name, phone);
            Console.WriteLine("Contact added!");
        }
    }
    public static void Remove()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            phoneBook.Remove(name);
            Console.WriteLine("Contact removed!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }
    public static void Search()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($"{name} -> {phoneBook[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }
    public static void Update()
    {
        Console.Write("Enter name and phone number [Name, +35900000]: ");
        string[] input = Console.ReadLine().Split(", ");
        string name = input[0];
        string phone = input[1];
        if (phoneBook.ContainsKey(name))
        {
            phoneBook[name] = phone;
            Console.WriteLine("Updated");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }

    public static void Print()
    {
        if (phoneBook.Count != 0)
        {
            foreach (var phone in phoneBook)
            {
                Console.WriteLine($"{phone.Key,-8} | {phone.Value}");
            }
        }
        else
        {
            Console.WriteLine("Phone book is empty!");
        }
    }
}