namespace Trucks.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Despatcher")]
    public class ExportDespatcherDto
    {
        [XmlElement("DespatcherName")]
        public string Name { get; set; }

        [XmlAttribute("TrucksCount")]
        public int TrucksCount { get; set; }

        [XmlArray("Trucks")]
        public ExportDespatcherTruckDto[] Trucks { get; set; }
    }
}
