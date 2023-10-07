namespace Trucks.DataProcessor
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Globalization;
    using System.Xml.Serialization;
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    using DataProcessor.ImportDto;
    using Trucks.Data;
    using Data.Models;
    using Data.Models.Enums;


    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        public static string ImportDespatcher(AppDbContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportDespatcherDto[]), new XmlRootAttribute("Despatchers"));

            using StringReader stringReader = new StringReader(xmlString);

            ImportDespatcherDto[] despatcherDtos = (ImportDespatcherDto[])xmlSerializer.Deserialize(stringReader);

            List<Despatcher> despatchers = new List<Despatcher>();

            foreach (ImportDespatcherDto despatcherDto in despatcherDtos)
            {
                if (!IsValid(despatcherDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                string position = despatcherDto.Position;
                bool isPositionInvalid = string.IsNullOrEmpty(position);

                if (isPositionInvalid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Despatcher d = new Despatcher()
                {
                    Name = despatcherDto.Name,
                    Position = position
                };

                foreach (ImportDespatcherTrucksDto truckDto in despatcherDto.Trucks)
                {
                    if (!IsValid(truckDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Truck t = new Truck()
                    {
                        RegistrationNumber = truckDto.RegistrationNumber,
                        VinNumber = truckDto.VinNumber,
                        TankCapacity = truckDto.TankCapacity,
                        CargoCapacity = truckDto.CargoCapacity,
                        CategoryType = (CategoryType)truckDto.CategoryType,
                        MakeType = (MakeType)truckDto.MakeType
                    };

                    d.Trucks.Add(t);
                }
                despatchers.Add(d);
                sb.AppendLine(String.Format(SuccessfullyImportedDespatcher, d.Name, d.Trucks.Count));
            }
            context.Despatchers.AddRange(despatchers);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        public static string ImportClient(AppDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportClientDto[] clientDtos = JsonConvert.DeserializeObject<ImportClientDto[]>(jsonString);

            List<Client> clients = new List<Client>();

            foreach (ImportClientDto clientDto in clientDtos)
            {
                if (!IsValid(clientDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Client c = new Client()
                {
                    Name = clientDto.Name,
                    Nationality = clientDto.Nationality,
                    Type = clientDto.Type,
                };

                if (c.Type == "usual")
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }


                foreach (int truckId in clientDto.Trucks.Distinct())
                {
                    Truck t = context.Trucks.Find(truckId);
                    if (t == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    c.ClientsTrucks.Add(new ClientTruck()
                    {
                        Truck = t
                    });
                }
                clients.Add(c);
                sb.AppendLine(String.Format(SuccessfullyImportedClient, c.Name, c.ClientsTrucks.Count));
            }
            context.Clients.AddRange(clients);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
