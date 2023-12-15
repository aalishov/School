using Castle.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Trucks.Data;
using Trucks.Data.Models;
using Trucks.DataProcessor.ExportDto;

namespace Trucks.Services
{
    public class ClientsService
    {
        private readonly AppDbContext context;

        public ClientsService(AppDbContext context)
        {
            this.context = context;
        }

        //CRUD
        public async Task<string> CreateClientAsync(string name, string nationality, string type)
        {
            Client client = new Client() { Name = name, Nationality = nationality, Type = type };
            List<ValidationResult> errors = IsValid(client);
            if (errors.Count == 0)
            {
                await context.Clients.AddAsync(client);
                await context.SaveChangesAsync();
                return "Client added!";
            }

            string[] errorMessages = errors.Select(x => x.ErrorMessage).ToArray();
            return string.Join($"{Environment.NewLine}", errorMessages);
        }

        public async Task<string> UpdateClientTypeAsync(int id, string newType)
        {
            Client client = await this.context.Clients.FindAsync(id);
            if (client != null)
            {
                client.Type = newType;
                List<ValidationResult> errors = IsValid(client);
                if (errors.Count == 0)
                {
                    context.Clients.Update(client);
                    await context.SaveChangesAsync();
                    return $"Client updated!";
                }

                string[] errorMessages = errors.Select(x => x.ErrorMessage).ToArray();
                return string.Join($"{Environment.NewLine}", errorMessages);
            }
            return "Invalid id!";
        }

        public async Task<string> DeleteClientByIdAsync(int id)
        {
            Client client = await this.context.Clients.FindAsync(id);
            if (client != null)
            {
                context.Clients.Remove(client);
                await context.SaveChangesAsync();
                return "Client deleted!";
            }
            return "Invalid id!";
        }
        public async Task<string> GetClientsByTypeAsync(string type)
        {
            ExportClientsByTypeDto exportClients = new ExportClientsByTypeDto() { Type=type};
            exportClients.Clients = await context.Clients.Where(x => x.Type == type)
                .Select(x => new ExportClientByTypeDto { Name = x.Name, Nationality = x.Nationality})
            .ToListAsync();
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(exportClients, options);
            return jsonString;
        }


        private static List<ValidationResult> IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            bool result = Validator.TryValidateObject(dto, validationContext, validationResult, true);
            return validationResult;
        }
    }
}
