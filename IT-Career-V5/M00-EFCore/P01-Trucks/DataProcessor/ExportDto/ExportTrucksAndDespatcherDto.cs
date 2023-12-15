using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucks.DataProcessor.ExportDto
{
    public class ExportTrucksAndDespatcherDto
    {
        public ExportTrucksAndDespatcherDto(string registrationNumber, string vinNumber, string name, string position)
        {
            RegistrationNumber = registrationNumber;
            VinNumber = vinNumber;
            Name = name;
            Position = position;
        }

        public string RegistrationNumber { get; set; }
        public string VinNumber { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
