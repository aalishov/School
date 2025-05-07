public class Car
{
    public Car(string brand, int hPower)
    {
        Brand = brand;
        HPower = hPower;
    }

    public string Brand { get; set; }
    public int HPower { get; set; }
    public override string ToString()
    {
        return $"{Brand}, {HPower}";
    }
}

