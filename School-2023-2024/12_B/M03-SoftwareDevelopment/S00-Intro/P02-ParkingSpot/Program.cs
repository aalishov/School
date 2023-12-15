using P02_ParkingSpot;

public class Program
{
    public static void Main()
    {
        
        ParkingController pk=new ParkingController();
        string result = pk.CreateParkingSpot(new List<string>() { "1", "true", "bus", "10" });
        Console.WriteLine(result);
        result= pk.CreateParkingSpot(new List<string>() { "21", "true", "subscription","SV1020KK" });
        Console.WriteLine(result);
        result= pk.CreateParkingSpot(new List<string>() { "3", "true", "kamion", "10", "SV1020KK" });
        Console.WriteLine(result);

    }
}
