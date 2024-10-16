public class Program
{
    public static void Main()
    {
        // Define const
        const double PriceNylon = 1.4;
        const double PricePaint = 14.5;
        const double PriceDiluent = 5.00;
        const double BagsPrice = 0.40;

        // Input
        int nylon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int diluent = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());


        double totalNylom = (nylon + 2) * PriceNylon;
        double totalPaint = paint * 1.1 * PricePaint;
        double totalDiluent = diluent * PriceDiluent;

        double totalMaterials = totalNylom + totalPaint + totalDiluent + BagsPrice;

        double workerPrice = totalMaterials * 0.3;
        double totalWorker = hours * workerPrice;

        double total = totalMaterials + totalWorker;
        Console.WriteLine(total);
    }
}

