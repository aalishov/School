
public class CarParkingSpot : ParkingSpot
{
    public CarParkingSpot(int id, bool occupied, double price) : base(id, occupied, AppConstants.CarSpotType, price)
    {
    }
}

