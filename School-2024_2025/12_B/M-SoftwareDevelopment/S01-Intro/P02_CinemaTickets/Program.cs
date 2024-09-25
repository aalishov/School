public class Program
{
    private static int ticketsCount = 0;
    private static int standartTicketsCount = 0;
    private static int studentTicketsCount = 0;
    private static int kidTicketsCount = 0;
    public static void Main()
    {
        while (true)
        {
            string movieName = Console.ReadLine();
            if (movieName == "Finish")
            {
                break;
            }
            int seats = int.Parse(Console.ReadLine());
            ticketsCount = 0;
            for (int i = 0; i < seats; i++)
            {
                string ticket = Console.ReadLine();
                if (ticket == "End")
                {
                    break;
                }
                else if (ticket == "standard")
                {
                    standartTicketsCount++;
                }
                else if (ticket == "student")
                {
                    studentTicketsCount++;
                }
                else if (ticket == "kid")
                {
                    kidTicketsCount++;
                }
                ticketsCount++;
            }
            Console.WriteLine($"{movieName} - {ticketsCount / (double)seats * 100.0:f2}% full.");
        }

        int totalTickets=studentTicketsCount+standartTicketsCount+kidTicketsCount;
        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{studentTicketsCount / (double)totalTickets * 100:f2}% student tickets.");
        Console.WriteLine($"{standartTicketsCount / (double)totalTickets * 100:f2}% standard tickets.");
        Console.WriteLine($"{kidTicketsCount / (double)totalTickets * 100:f2}% kids tickets.");
    }
}

