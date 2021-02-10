namespace RealEstates.Services.Models
{
    public class PropertyInputViewModel
    {
        public string District { get; set; }

        public int Size { get; set; }

        public int Price { get; set; }

        public int? Year { get; set; }

        public string PropertyType { get; set; }

        public string BuildingType { get; set; }

        public int? Floor { get; set; }

        public int? TotalFloors { get; set; }
    }
}
