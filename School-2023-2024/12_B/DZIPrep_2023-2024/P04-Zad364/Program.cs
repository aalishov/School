using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string UCN = Console.ReadLine();
        int year = int.Parse(UCN.Substring(0, 2));
        int month = int.Parse(UCN.Substring(2, 2));
        int date = int.Parse(UCN.Substring(4, 2));
        string gender = int.Parse(UCN.Substring(8, 1)) % 2 == 0 ? "Man" : "Woman";
        if (month > 40)
        {
            month -= 40;
            year += 2000;
        }
        else if (month > 20)
        {

            month -= 20;
            year += 1800;
        }
        else
        {
            year += 1900;
        }
        string result = $"{gender} born on date {date.ToString("00")}/{month.ToString("00")}/{year}";
        Console.WriteLine(result);

    }
}
