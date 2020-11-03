namespace P05_BestPlaneTickets
{
    using System;
    class Program
    {
        static void Main()
        {
            const decimal evro = 1.96m;

            string shortestFlight = string.Empty;
            decimal shortestFlightPrice = decimal.MaxValue;
            int shortestFlighttMinutes = int.MaxValue;

            while (true)
            {
                Console.Write("Entre fligh number: ");
                string flight = Console.ReadLine();
                if (flight=="End")
                {
                    break;
                }
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.Write("Minutes: ");
                int minutes = int.Parse(Console.ReadLine());

                if (minutes<shortestFlighttMinutes)
                {
                    shortestFlighttMinutes = minutes;
                    shortestFlightPrice = price;
                    shortestFlight = flight;
                }
            }
            int hours = shortestFlighttMinutes / 60;
            int minutesInOut = shortestFlighttMinutes % 60;

            Console.WriteLine($"Ticket found for flight {shortestFlight} costs {shortestFlightPrice*evro} leva with {hours}h {minutesInOut}m stay");
        }
    }
}
