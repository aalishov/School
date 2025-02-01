using BarberRating.Data;
using BarberRating.Data.Models;
using BarberRating.Services.Contracts;
using BarberRating.ViewModels.Barbers;
using Microsoft.EntityFrameworkCore;

namespace BarberRating.Services
{
    public class BarbersService : IBarbersService
    {
        private readonly ApplicationDbContext context;

        public BarbersService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<string> UpdateBarberAsync(EditBarberViewModel model)
        {
            Barber? barber = await context
                .Barbers
                .FindAsync(model.Id);

            barber.Name = model.Name;
            barber.Description = model.Description;

            context.Barbers.Update(barber);
            await context.SaveChangesAsync();
            return barber.Id;
        }

        public async Task<EditBarberViewModel> GetBarberToEditAsync(string barberId)
        {
            Barber? barber = await context
                .Barbers
                .FindAsync(barberId);

            return new EditBarberViewModel()
            {
                Id = barberId,
                Name = barber.Name,
                Description = barber.Description,
            };
        }

        public async Task<string> CreateBarberAsync(CreateBarberViewModel model)
        {
            Barber barber = new Barber()
            {
                Name = model.Name,
                Description = model.Description,
                Image = await ImageToStringAsync(model.ImageFile),
            };
            await context.Barbers.AddAsync(barber);
            await context.SaveChangesAsync();

            return barber.Id;
        }

        public async Task<IndexBarbersViewModel> GetBarbersAsync(IndexBarbersViewModel model)
        {
            if (model == null)
            {
                model = new IndexBarbersViewModel(10);
            }
            IQueryable<Barber> dataBarbers = context.Barbers;

            if (!string.IsNullOrWhiteSpace(model.FilterByName))
            {
                dataBarbers = dataBarbers.Where(x => x.Name.Contains(model.FilterByName));
            }

            if (model.IsAsc)
            {
                model.IsAsc = false;
                dataBarbers.OrderByDescending(x => x.Name);
            }
            else
            {
                model.IsAsc = true;
                dataBarbers.OrderBy(x => x.Name);
            }

            model.ElementsCount = await dataBarbers.CountAsync();

            model.Barbers = await dataBarbers
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexBarberViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                })
                .ToListAsync();

            return model;
        }



        private async Task<string> ImageToStringAsync(IFormFile file)
        {
            List<string> imageExtensions = new List<string>() { ".JPG", ".BMP", ".PNG" };


            if (file != null) // check if the user uploded something
            {
                var extension = Path.GetExtension(file.FileName); //get file extension
                if (imageExtensions.Contains(extension.ToUpperInvariant()))
                {
                    using var dataStream = new MemoryStream();
                    await file.CopyToAsync(dataStream);
                    byte[] imageBytes = dataStream.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
            return null;
        }
    }
}
