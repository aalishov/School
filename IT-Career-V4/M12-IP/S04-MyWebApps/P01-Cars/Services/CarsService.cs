using Microsoft.EntityFrameworkCore;
using P01_Cars.Data;
using P01_Cars.Data.Models;
using P01_Cars.ViewModels.Cars;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace P01_Cars.Services
{
    public class CarsService : ICarsService
    {
        private readonly AppDbContext context;

        public CarsService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<IndexCarViewModel>> GetCarsBasicInfoAsync()
        {
            return await this.context.Cars
                .Select(c => new IndexCarViewModel()
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                })
                .ToListAsync();
        }

        public async Task<DetailsCarViewModel> GetCarDetailsAsync(int id)
        {
            Car car = await this.context.Cars.FindAsync(id);

            if (car != null)
            {
                return new DetailsCarViewModel
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    ProductionDate = car.ProductionDate.ToShortDateString(),
                    IsAvailable = car.IsAvailable ? "Available" : "Not available",
                    Color = car.Color.ToString(),
                    ImageUrl = car.ImageUrl
                };
            }
            return null;
        }

        public async Task CreateCarAsync(CreateCarViewModel inputModel)
        {
            Car car = new Car()
            {
                Brand = inputModel.Brand,
                Model = inputModel.Model,
                Color = inputModel.Color,
                ProductionDate = inputModel.ProductionDate,
                Price = inputModel.Price,
                IsAvailable = true,
                ImageUrl = inputModel.ImageUrl
            };
            await context.Cars.AddAsync(car);
            await context.SaveChangesAsync();
        }
    }
}
