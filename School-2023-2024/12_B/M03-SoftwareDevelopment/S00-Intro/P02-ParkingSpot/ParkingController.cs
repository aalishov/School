using P02_ParkingSpot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParkingController
{
    List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
    public string CreateParkingSpot(List<string> args)
    {
        ParkingSpot parkingSpot = null;
        int id = int.Parse(args[0]);
        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);
        if (parkingSpots.FirstOrDefault(x => x.Id == id) != null)
        {
            return $"Parking spot {id} is already registered!";
        }
        if (type == "subscription")
        {
            string registrationPlate = args[4];
             parkingSpot = new SubscriptionParkingSpot(id,occupied,price,registrationPlate);
           
        }
        else if (type=="car")
        {
            parkingSpot = new CarParkingSpot(id, occupied, price);
        }
        else if (type=="bus")
        {
            parkingSpot = new BusParkingSpot(id, occupied, price);
        }
        else
        {
            return $"Unable to create parking spot!";
        }
        parkingSpots.Add(parkingSpot);
        return $"Parking spot {parkingSpot.Id} was successfully registered in the system!";
    }

    //public string ParkVehicle(List<string> args)
    //{
    //    //TODO: Add some logic here …
    //}

    //public string FreeParkingSpot(List<string> args)
    //{
    //    //TODO: Add some logic here …
    //}

    //public string GetParkingSpotById(List<string> args)
    //{
    //    //TODO: Add some logic here …
    //}

    //public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(int parkingSpotId)
    //{
    //    //TODO: Add some logic here …
    //}
    //public string CalculateTotal()
    //{
    //    //TODO: Add some logic here …
    //}

}
