namespace P02_StudentsServices
{
    using P02_StudentsAppData;
    using P02_StudentsAppData.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TownsService : ITownsService
    {
        private readonly ApplicationDbContext dbContext;
        private ICountriesService countryService;

        public TownsService(ApplicationDbContext dbContext, ICountriesService countryService)
        {
            this.dbContext = dbContext;
            this.countryService = countryService;
        }
        public string AddTown(string townName, string countryName)
        {
            StringBuilder sb = new StringBuilder();

            Country country = countryService.GetCountryByName(countryName);

            if (country == null)
            {
                sb.AppendLine(countryService.AddCountry(countryName));
                country = countryService.GetCountryByName(countryName);
            }

            Town town = this.GetTownByName(townName, countryName);
            if (town == null)
            {
                town = new Town()
                {
                    Name = townName,
                    CountryId = country.Id,
                };
                dbContext.Towns.Add(town);
                dbContext.SaveChanges();
                sb.AppendLine($" >> Town {townName} is added!");
                return sb.ToString().TrimEnd();
            }
            else
            {
                return $">> Town {townName} already exist!";
            }
        }

        public string GetAllTowns()
        {
            StringBuilder sb = new StringBuilder();

            List<Town> towns = dbContext.Towns.ToList();

            sb.AppendLine(">> Towns list");
            sb.AppendLine(new string('-', 30));
            sb.AppendLine($"{ "Id",3} | { "Name",10} | {"Country",10}");
            sb.AppendLine(new string('-', 30));
            foreach (var town in towns)
            {
                sb.AppendLine($"{ town.Id,3} | {town.Name,10} | {town.Country.Name,10}");
            }
            sb.AppendLine(new string('-', 30));

            return sb.ToString().TrimEnd();
        }

        public Town GetTownByName(string townName, string countryName)
        {
            return this.dbContext.Towns.FirstOrDefault(x => x.Name == townName && x.Country.Name == countryName);
        }
    }
}
