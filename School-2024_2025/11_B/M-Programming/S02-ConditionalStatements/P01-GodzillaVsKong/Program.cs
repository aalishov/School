public class Program
{
    public static void Main()
    {
        double bFilm = double.Parse(Console.ReadLine());
        int ststisti = int.Parse(Console.ReadLine());
        double cenaNaObl = double.Parse(Console.ReadLine());
        double dekor = bFilm / 10;


        if (ststisti > 150)
        {
            cenaNaObl = cenaNaObl * 0.9;
        }
        double nedos = Math.Abs(bFilm - (dekor + (cenaNaObl * ststisti)));

        if (dekor + (cenaNaObl * ststisti) > bFilm)
        {
            Console.WriteLine($"Not enough money!");
            Console.WriteLine($"Wingard needs {nedos:f2} leva more.");
        }
        else
        {
            Console.WriteLine($"Action!");
            Console.WriteLine($"Wingard starts filming with {nedos:f2} leva left.");
        }

    }
}

