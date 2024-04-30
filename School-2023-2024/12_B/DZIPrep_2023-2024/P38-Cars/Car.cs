public class Car
{
    public Car(string brand, int year, int mileage, double value)
    {
        Brand = brand;
        Year = year;
        Mileage = mileage;
        Value = value;
    }

    public string Brand { get; set; }

    public int Year { get; set; }

    public int Mileage { get; set; }

    public double Value { get; set; }

    public virtual double Price()
    {
        if (DateTime.Now.Year - Year <= 3)
        {
            return Value * 0.8;
        }
        else if (DateTime.Now.Year - Year >= 7)
        {
            return Value * 0.3;
        }
        else { return Value * 0.6; }
    }
    public override string ToString()
    {
        return $"{Brand}: {Mileage} km, {Price():f2}";
    }
}

