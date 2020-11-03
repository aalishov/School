using System;

public class Program

{
    static int totalTickets = 0;
    static int kidTickets = 0;
    static int standardTickets = 0;
    static int studentTickets = 0;
    static void Main()
    {
        Engine();
        Print();
    }

    private static void Engine()
    {
        while (true)
        {
            Console.Write("Movie: ");
            string movie = Console.ReadLine();
            if (movie == "Finish")
            {
                break;
            }
            Console.Write("Seats: ");
            int seats = int.Parse(Console.ReadLine());
            int usedSeats = 0;
            usedSeats = ReadMovieInfo(seats, usedSeats);
            PrintMovieInfo(movie, seats, usedSeats);
        }
    }

    private static double CalculatePercentage(int usedSeats,int seats)
    {
        return usedSeats / (double)seats * 100;
    }

    private static void PrintMovieInfo(string movie, int seats, int usedSeats)
    {
        Console.WriteLine($"{movie} - {CalculatePercentage(usedSeats,seats)}% full.");
    }

    private static int ReadMovieInfo(int seats, int usedSeats)
    {
        while (seats > usedSeats)
        {
            Console.Write("Ticket type: ");
            string ticket = Console.ReadLine();
            if (ticket == "End")
            {
                break;
            }
            usedSeats++;
            totalTickets++;
            switch (ticket)
            {
                case "standard":
                    standardTickets++;
                    break;
                case "kid":
                    kidTickets++;
                    break;
                case "student":
                    studentTickets++;
                    break;
            }
        }

        return usedSeats;
    }

    private static void Print()
    {
        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{CalculatePercentage(studentTickets, totalTickets):f2}% student tickets.");
        Console.WriteLine($"{CalculatePercentage(standardTickets,totalTickets):f2}% standard tickets.");
        Console.WriteLine($"{CalculatePercentage(kidTickets,totalTickets):f2}% kids tickets.");
    }
}
