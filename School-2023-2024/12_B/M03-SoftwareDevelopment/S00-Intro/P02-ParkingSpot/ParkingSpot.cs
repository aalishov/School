using P02_ParkingSpot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class ParkingSpot
{
    
    private double price;

    protected ParkingSpot(int id, bool occupied, string type, double price)
    {
        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
        ParkingIntervals= new();
    }
    public List<ParkingInterval> ParkingIntervals { get; set; }
    public int Id { get; set; }
    public bool Occupied { get; set; }
    public string Type { get; set; }
    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
            }
            price = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"> Parking Spot #{Id}");
        sb.AppendLine($"> Occupied: {Occupied}");
        sb.AppendLine($"> Type: {Type}");
        sb.AppendLine($"> Price per hour: {Price:f2} BGN");
        return sb.ToString().TrimEnd();
    }
}

