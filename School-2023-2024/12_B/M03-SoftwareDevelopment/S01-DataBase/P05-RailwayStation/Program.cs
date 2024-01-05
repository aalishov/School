using P05_RailwayStation.Data;
using System.Security.Cryptography.X509Certificates;

namespace P05_RailwayStation
{
    internal class Program
    {
        private static AppDbContext context = new AppDbContext();
        static void Main()
        {
            
        }

        private static void GetFirstTrainsBetween8_00And8_59()
        {
            var resultByObject = context.Tickets.Where(x => x.Train.HourOfDeparture.Hour == 8 && x.Price > 50)
               .OrderBy(x => x.Price).ThenBy(x => x.TrainId)
               .Select(x =>
                            new
                            {
                                TrainId = x.TrainId,
                                HourOfDeparture = x.Train.HourOfDeparture.ToString("hh-mm"),
                                Price = x.Price,
                                Destination = x.Train.ArrivalTown.Name
                            }
               );


            var result = context.Tickets.Where(x => x.Train.HourOfDeparture.Hour == 8 && x.Price > 50)
                .OrderBy(x => x.Price).ThenBy(x => x.TrainId)
                .Select(x => $"{x.TrainId} {x.Train.HourOfDeparture.ToString("hh-mm")} {x.Price} {x.Train.ArrivalTown.Name}");

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GetRailwayStationsWithoutPassingTrains()
        {
            var trainsAttending = context.TrainsRailwayStations.Select(x => x.RailwayStationId).ToList();

            var result = context.RailwayStations
                .Where(x => !trainsAttending.Contains(x.Id))
                .Select(x => $"{x.Town.Name,-15} - {x.Name,-15}").ToList()
                .OrderBy(x => x);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GetPassengersWithTheirTickets()
        {
            var result = context.Tickets
                .OrderByDescending(x => x.Price).ThenBy(x => x.Passenger.Name)
                .Select(x => $"{x.Passenger.Name,20} - {x.Price,5} - {x.DateOfDeparture.ToString("yyyy-MM-dd"),10} - {x.TrainId,3}");

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GetTicketsByPriceAndDateOfDeparture()
        {
            var result = context.Tickets.OrderBy(x => x.Price).ThenByDescending(x => x.DateOfDeparture)
                .Select(x => $"{x.DateOfDeparture.ToString("dd-MM-yyyy")} - {x.Price}");

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}