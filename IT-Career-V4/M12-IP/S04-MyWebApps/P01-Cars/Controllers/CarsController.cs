namespace P01_Cars.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using P01_Cars.Services;
    using P01_Cars.ViewModels;
    using P01_Cars.ViewModels.Cars;
    using System.Collections.Generic;
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
            return NotFound();
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
                return View(inputModel);
            }

            await carsService.CreateCarAsync(inputModel);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            EditCarViewModel editModel = await carsService.GetCarToEditAsync(id);
            if (editModel == null)
            {
                return NotFound();
            }
            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCarViewModel editModel)
        {
            if (!ModelState.IsValid) { return View(editModel); }

            await this.carsService.UpdateCarDetailsAsync(editModel);
            return RedirectToAction(nameof(Details), new {editModel.Id});
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.carsService.DeleteCarByIdAsync(id);
            return this.RedirectToAction(nameof(Index));
        }
    }
}
