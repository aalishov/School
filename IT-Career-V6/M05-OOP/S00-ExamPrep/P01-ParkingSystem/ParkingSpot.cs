using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


public abstract class ParkingSpot
{
    private double price;
    private List<ParkingInterval> parkingIntervals;

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }

    public int Id { get; set; }

    public bool Occupied { get; set; }

    public string Type { get; set; }

    public virtual double Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
            }
            this.price = value;
        }
    }

    public IReadOnlyList<ParkingInterval> ParkingIntervals
    {
        get { return this.parkingIntervals; }
    }

    public void AddInterval(ParkingInterval interval)
    {
        this.parkingIntervals.Add(interval);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"> Parking Spot #{this.Id}");
        sb.AppendLine($"> Occupied: {this.Occupied}");
        sb.AppendLine($"> Type: {this.Type}");
        sb.AppendLine($"> Price per hour: {this.Price:f2} BGN");
        
        return sb.ToString().TrimEnd();
    }

   
}

