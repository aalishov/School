using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucks.DataProcessor.ExportDto
{
    public class ExportClientsByTypeDto
    {
        public string Type { get; set; }
        public ICollection<ExportClientByTypeDto> Clients { get; set; }
    }
}
