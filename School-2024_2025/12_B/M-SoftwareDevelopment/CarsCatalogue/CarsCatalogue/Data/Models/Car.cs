namespace CarsCatalogue.Data.Models
{
    public class Car
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string ModelId { get; set; }
        public virtual Model Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string? ImageURL { get; set; }
    }
}
