using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BusParkingSpot : ParkingSpot
{
    private const string SpotType = "bus";
    public BusParkingSpot(int id, bool occupied, double price) : base(id, occupied, SpotType, price)
    {
    }
}

