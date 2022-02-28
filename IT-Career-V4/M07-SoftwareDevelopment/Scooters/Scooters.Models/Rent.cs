namespace Scooters.Models
{
    using System;
    public class Rent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ScooterId { get; set; }
        public virtual Scooter Scooter { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsComleted { get; set; }
        public string Description { get; set; }
    }
}
