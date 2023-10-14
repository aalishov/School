using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParkingController
{
    private Dictionary<int, ParkingSpot> parkingSpots = new();

    public string CreateParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);
        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);

        if (parkingSpots.ContainsKey(id))
        {
            return $"Parking spot {id} is already registered!";
        }
        ParkingSpot spot = null;
        if (type == AppConstants.CarSpotType)
        {
            spot = new CarParkingSpot(id, occupied, price);
        }
        else if (type == AppConstants.BusSpotType)
        {
            spot = new BusParkingSpot(id, occupied, price);
        }
        else if (type == AppConstants.SubscriptionSpotType)
        {
            string registrationPlate = args[4];
            spot = new SubscriptionParkingSpot(id, occupied, price, registrationPlate);
        }
        else
        {
            return $"Unable to create parking spot!";
        }
        parkingSpots.Add(id, spot);
        return $"Parking spot {spot.Id} was successfully registered in the system!";
    }

    public string ParkVehicle(List<string> args)
    {
        int id = int.Parse(args[0]);
        string registrationPlate = args[1];
        int hoursParked = int.Parse(args[2]);
        string type = args[3];

        if (!parkingSpots.ContainsKey(id))
        {
            return $"Parking spot {id} not found!";
        }
        if (parkingSpots[id].Occupied || parkingSpots[id].Type != type)
        {
            return $"Vehicle {registrationPlate} can't park at {id}.";
        }

        parkingSpots[id].Occupied = true;
        parkingSpots[id].AddInterval(new ParkingInterval(parkingSpots[id], registrationPlate, hoursParked));

        return $"Vehicle {registrationPlate} parked at {id} for {hoursParked} hours.";
    }

    public string FreeParkingSpot(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);

        if (!parkingSpots.ContainsKey(parkingSpotId))
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        if (!parkingSpots[parkingSpotId].Occupied)
        {
            return $"Parking spot {parkingSpotId} is not occupied.";
        }
        parkingSpots[parkingSpotId].Occupied = false;
        return $"Parking spot {parkingSpotId} is now free!";
    }

    public string GetParkingSpotById(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);

        if (!parkingSpots.ContainsKey(parkingSpotId))
        {
            return $"Parking spot {parkingSpotId} not found!";
        }

        return parkingSpots[parkingSpotId].ToString();
    }

    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];

        if (!parkingSpots.ContainsKey(parkingSpotId))
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        List<ParkingInterval> intervals = parkingSpots[parkingSpotId]
            .ParkingIntervals
            .Where(x => x.RegistrationPlate == registrationPlate)
            .ToList();
        StringBuilder sb = new();
        intervals.ForEach(x => sb.AppendLine(x.ToString()));
        return sb.ToString().TrimEnd();
    }
    public string CalculateTotal()
    {
        double total = parkingSpots.Values.Sum(x => x.ParkingIntervals.Sum(x => x.Revenue));
        return $"Total revenue from the parking: {total:F2} BGN";
    }
}

