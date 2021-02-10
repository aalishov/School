namespace P02_StudentsServices
{
    using P02_StudentsAppData;
    using P02_StudentsAppData.Models;
    using System.Linq;
    using System.Text;

    public class AddressesService : IAddressesService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ITownsService townsService;

        public AddressesService(ApplicationDbContext dbContext, ITownsService townsService)
        {
            this.dbContext = dbContext;
            this.townsService = townsService;
        }

        public string AddAddress(string addressName, string townName, string countryName)
        {
            StringBuilder sb = new StringBuilder();


            Town town = townsService.GetTownByName(townName, countryName);

            if (town == null)
            {
                sb.AppendLine(townsService.AddTown(townName, countryName));
                town = townsService.GetTownByName(townName, countryName);
            }

            Address address = GetAddressByName(addressName, townName, countryName);

            if (address == null)
            {
                address = new Address()
                {
                    Name = addressName,
                    Town = town
                };
                dbContext.Addresses.Add(address);
                dbContext.SaveChanges();
                sb.AppendLine($">> Address {addressName} is added!");
                return sb.ToString().TrimEnd();
            }
            else
            {
                return $">> Address {addressName} already exist!";
            }
        }

        public Address GetAddressByName(string addressName, string townName, string countryName)
        {
            return this.dbContext.Addresses.FirstOrDefault(x =>
            x.Name == addressName &&
            x.Town.Name == townName &&
            x.Town.Country.Name == countryName);
        }
    }
}
