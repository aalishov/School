public class Program
{
    public static void Main()
    {
        byte hh = byte.Parse(Console.ReadLine());
        byte mm = byte.Parse(Console.ReadLine());

        mm += 15;

        if (mm>=60)
        {
            mm -= 60;
            hh++;
            if (hh > 23)
            {
                hh = 0;
            }
        }
        
        if (mm<10)
        {
            Console.WriteLine($"{hh}:0{mm}");
        }
        else
        {
            Console.WriteLine($"{hh}:{mm}");
        }
    }
}

