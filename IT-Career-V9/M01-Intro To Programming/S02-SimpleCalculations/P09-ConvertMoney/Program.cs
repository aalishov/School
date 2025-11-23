public class Program
{
    private const double BGNtoUSD = 1.79549;
    private const double BGNtoEUR = 1.95583;
    private const double BGNtoGBP = 2.53405;
    public static void Main()
    {
        // && - and, 5>2 && 10<3 = false;
        // || - or,  5>2 || 10<3 = true;

        double value = double.Parse(Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();

        double result = 0.0;

        if (from == "BGN" && to == "EUR")
        {
            result = value / BGNtoEUR;
        }
        else if (from == "EUR" && to == "BGN")
        {
            result = value * BGNtoEUR;
        }
        else if (from == "EUR" && to == "GBP")
        {
            result = value * BGNtoEUR / BGNtoGBP;
        }
        //TODO: 

        Console.WriteLine($"{result:f2} {to}");
    }
}

