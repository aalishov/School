namespace CarsCatalogue.Models.Cars
{
    public class CreateCarViewModel
    {
        public int Year { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string ModelId { get; set; }
        public string? ImageURL { get; set; }
    }
}
