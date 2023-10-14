using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SubscriptionParkingSpot : ParkingSpot
{

    private string registrationPlate;

    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, AppConstants.SubscriptionSpotType, price)
    {
        this.RegistrationPlate = registrationPlate;
    }

    public override double Price { get => 0; set => base.Price = value; }

    public string RegistrationPlate
    {
        get { return registrationPlate; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Registration plate can’t be null or empty!");
            }
            this.registrationPlate = value;
        }
    }
}

