public class Program
{
    public static void Main()
    {
        string result = PrintStudentInfo("Jane");
        Console.WriteLine(result);
        result = PrintStudentInfo("John", 16);
        Console.WriteLine(result);
        result = PrintStudentInfo("Jane", 15, "Vasil Levski", "Kristal 10");
        Console.WriteLine(result);
       
    }
    public static string PrintStudentInfo(string name, int age, string school, string address)
    {
        return $"Name: {name}{Environment.NewLine}Age: {age}{Environment.NewLine}Address: {address}{Environment.NewLine}School: {school}";
    }
    public static string PrintStudentInfo(string name)
    {
        return $"Name: {name}{Environment.NewLine}Age: n/a{Environment.NewLine}Address: n/a{Environment.NewLine}School: n/a";
    }
    public static string PrintStudentInfo(string name, int age)
    {
        return $"Name: {name}{Environment.NewLine}Age: {age}{Environment.NewLine}Address: n/a{Environment.NewLine}School: n/a";
    }

    public static void PrintHeader(int count)
    {
        Console.WriteLine(new string('.', count));
    }
    public static void PrintHeader(char c)
    {
        Console.WriteLine(new string(c, 20));
    }

    public static void PrintHeader(char c = '-', int count = 10)
    {
        Console.WriteLine(new string(c, count));
    }

    public static void PrintFooter(double total)
    {
        Console.WriteLine($"Total: {total:f2}");
    }

    public static void PrintReceipt()
    {
        PrintHeader();
        Products();
        PrintHeader('_', 10);
        PrintFooter(150.26786252);
    }

    public static void Products()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Product: ???");
        }
    }
}
