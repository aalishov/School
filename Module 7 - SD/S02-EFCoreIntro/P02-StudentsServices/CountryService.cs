
namespace P02_StudentsServices
{
    using P02_StudentsAppData.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CountryService : BaseService
    {
        //Create
        public string AddCountry(string name)
        {
            Country country = GetCountryByName(name);

            if (country==null)
            {
                this.dbContext.Countries.Add(new Country() { Name = name });
                dbContext.SaveChanges();
                return $"Country {name} is added!";
            }
            else
            {
                return $"Country {name} already exist!";
            }
        }

        //Reade
        public string GetAllCountries()
        {
            StringBuilder sb = new StringBuilder();
            List<Country> countries = dbContext.Countries.ToList();
            sb.AppendLine(new string('-',30));
            sb.AppendLine($"{"Id",3} | {"Name",10}");
            sb.AppendLine(new string('-', 30));
            foreach (var c in countries)
            {
                sb.AppendLine($"{c.Id,3} | {c.Name,10}");
            }
            sb.AppendLine(new string('-', 30));
            return sb.ToString().TrimEnd();
        }

        //Update
        public string EditCoutryNameById(int id, string newName)
        {
            Country country = GetCountryById(id);
            if (country!=null)
            {
                country.Name = newName;
                dbContext.Countries.Update(country);
                dbContext.SaveChanges();
                return $"Country with id: {id} has new name: {newName}";
            }
            else
            {
                return $"Country with id: {id} not found!";
            }
        }

        public Country GetCountryById(int id)
        {
            return this.dbContext.Countries.FirstOrDefault(x => x.Id == id);
        }
        public Country GetCountryByName(string name)
        {
            return this.dbContext.Countries.FirstOrDefault(x => x.Name == name);
        }
    }
}
