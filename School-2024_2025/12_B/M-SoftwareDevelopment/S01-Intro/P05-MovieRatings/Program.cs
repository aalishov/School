
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string highstRatingFilm = string.Empty;
        string lowRatingFilm = string.Empty;
        double highstRating = int.MinValue;
        double lowstRating = int.MaxValue;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());
            if (rating > highstRating)
            {
                highstRating = rating;
                highstRatingFilm = name;
            }
            if (rating < lowstRating)
            {
                lowstRating = rating;
                lowRatingFilm = name;
            }
            sum += rating;
        }
        double average = sum / n;
        Console.WriteLine($"{highstRatingFilm} is with highest rating: {highstRating:f1}");
        Console.WriteLine($"{lowRatingFilm} is with lowest rating: {lowstRating:f1}");
        Console.WriteLine($"Average rating: {average:f1}");
    }
}

