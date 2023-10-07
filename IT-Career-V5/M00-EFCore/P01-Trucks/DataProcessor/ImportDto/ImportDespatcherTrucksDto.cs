namespace Trucks.DataProcessor.ImportDto
{
    using System.Xml.Serialization;
    using System.ComponentModel.DataAnnotations;

    [XmlType("Truck")]

    public class ImportDespatcherTrucksDto
    {
        [Required]
        [RegularExpression("[A-Z][A-Z][0-9]{4}[A-Z][A-Z]")]
        public string RegistrationNumber { get; set; }

        [Required]
        [StringLength(17)]
        public string VinNumber { get; set; }

        [XmlElement("TankCapacity")]
        [Range(950, 1420)]
        public int TankCapacity { get; set; }

        [XmlElement("CargoCapacity")]
        [Range(5000, 29000)]
        public int CargoCapacity { get; set; }

        [Required]
        [XmlElement("CategoryType")]
        [Range(0, 3)]
        public int CategoryType { get; set; }

        [Required]
        [XmlElement("MakeType")]
        [Range(0, 4)]
        public int MakeType { get; set; }
    }
}
