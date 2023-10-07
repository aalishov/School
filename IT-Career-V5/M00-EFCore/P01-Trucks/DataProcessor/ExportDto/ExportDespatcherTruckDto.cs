namespace Trucks.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Truck")]
    public class ExportDespatcherTruckDto
    {
        [XmlElement("RegistrationNumber")]
        public string RegistrationNumber { get; set; }

        [XmlElement("Make")]
        public string Make { get; set; }
    }
}
