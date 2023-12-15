using MyApp.Data;
using MyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class CarsService
    {
        AppDbContext db = new AppDbContext();

        public List<IndexCarViewModel> GetCarsByBrand(string brand)
        {
            return db.Cars
                .Where(x => x.Brand == brand)
                .Select(c => new IndexCarViewModel() { Brand = c.Brand, Model = c.Model })
                .ToList();
        }
    }


}
