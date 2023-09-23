namespace P01_TouristSites.Services
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using P01_TouristSites.Data.Models;

    public class TouristsService
    {
        private readonly AppDbContext appDbContext;

        public TouristsService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<string> CreateTouristAsync(string name, int age, string phoneNumber, string nationality, string reward)
        {
            Tourist t = await FindTouristAsync(name, age, phoneNumber);
            if (t != null)
            {
                return "Tourist already exists...";
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Invalid name...";
            }
            if (age <= 0 || age > 110)
            {
                return "Invalid age...";
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return "Invalid phoneNumber...";
            }
            if (string.IsNullOrWhiteSpace(nationality))
            {
                return "Invalid nationality...";
            }
            t = new Tourist()
            {
                Name = name,
                Age = age,
                PhoneNumber = phoneNumber,
                Nationality = nationality,
                Reward = reward
            };
            await appDbContext.Tourists.AddAsync(t);
            await appDbContext.SaveChangesAsync();
            return $"Tourist added successfully";
        }



        public async Task<string> UpdateTouristAsync(string name, int age, string phoneNumber, string newReward, string newPhoneNumber)
        {
            Tourist t = await FindTouristAsync(name, age, phoneNumber);
            if (t == null) { return $"Tourist does not exist..."; }
            string result = string.Empty;
            if (string.IsNullOrWhiteSpace(newPhoneNumber))
            {
                result += "Invalid new phone number";
            }
            else
            {
                t.PhoneNumber = newPhoneNumber;
                result += "Phone number updated...";
            }
            if (string.IsNullOrWhiteSpace(newReward))
            {
                result += "\n\rInvalid new reward";
            }
            else
            {
                t.Reward = newReward;
                result += "\n\tReward updated...";
            }

            appDbContext.Tourists.Update(t);
            await appDbContext.SaveChangesAsync();
            return result;
        }
        public async Task<string> GetTouristInfoAsync(string name, int age, string phoneNumber)
        {
            Tourist t = await FindTouristAsync(name, age, phoneNumber);
            if (t != null)
            {
                return $"Tousirt {t.Name}, {t.Age} has phone number {t.PhoneNumber} and is from {t.Nationality}";
            }
            return $"Tousirt does not exist...";
        }
        public async Task<string> GetTouristsInfoAsync(int page=1, int itemsPerPage=5)
        {
            List<string> list = await appDbContext.Tourists
                .Skip(itemsPerPage*page-1)
                .Take(itemsPerPage)
                .Select(x=>$"Tourist- {x.Name}, {x.Age}, {x.PhoneNumber}, {x.Nationality}, {x.Reward}")
                .ToListAsync();
           return string.Join("\n\r",list);
        }
        public async Task<string> DeleteTouristAsync(string name, int age, string phoneNumber)
        {
            Tourist t = await FindTouristAsync(name, age, phoneNumber);
            if (t!=null)
            {
                appDbContext.Tourists.Remove(t);
                await appDbContext.SaveChangesAsync();
                return $"Tourist removed successfully";
            }
            return $"Tourist does not exist...";
        }
        private async Task<Tourist> FindTouristAsync(string name, int age, string phoneNumber)
        {
            return await appDbContext.Tourists.FirstOrDefaultAsync(x => x.Name == name && x.Age == age && x.PhoneNumber == phoneNumber);
        }
    }
}
