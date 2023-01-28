namespace P01_Cars.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using P01_Cars.Services;
    using P01_Cars.ViewModels;
    using P01_Cars.ViewModels.Cars;
    using System.Threading.Tasks;

    public class CarsController : Controller
    {
        private readonly ICarsService carsService;

        public CarsController(ICarsService carsService)
        {
            this.carsService = carsService;
        }

        public async Task<IActionResult> Index()
        {
            IndexCarsViewModel model = new IndexCarsViewModel()
            {
                Cars = await carsService.GetCarsBasicInfoAsync()
            };
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            DetailsCarViewModel model = await carsService.GetCarDetailsAsync(id);
            if (model != null)
            {
                return View(model);
            }
            return this.RedirectToAction("Error", "Home");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCarViewModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Create));
            }

            await carsService.CreateCarAsync(inputModel);

            return RedirectToAction(nameof(Index));
        }
    }
}
