namespace BarberRating.Data.Models
{
    public class Review
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string BarberId { get; set; }

        public virtual Barber Barber { get; set; }

        public double Rating { get; set; }

        public string ReviewText { get; set; }
    }
}
