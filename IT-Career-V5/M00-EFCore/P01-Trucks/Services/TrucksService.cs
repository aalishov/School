using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Trucks.Data;
using Trucks.DataProcessor.ExportDto;

namespace Trucks.Services
{
    public class TrucksService
    {
        private readonly AppDbContext context;

        public TrucksService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<string> GetTrucksAndDespatchers()
        {
            List<ExportTrucksAndDespatcherDto> exportTrucksAndDespatchers = context.Trucks.Select(x=>new ExportTrucksAndDespatcherDto(x.RegistrationNumber,x.VinNumber,x.Despatcher.Name,x.Despatcher.Position)).ToList();

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(exportTrucksAndDespatchers, options);
            File.WriteAllText("result.json",jsonString);
            return jsonString;
        }
    }
}
