using Microsoft.AspNetCore.Mvc;
using RealEstates.Data;
using RealEstates.Services;
using RealEstates.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstates.Web.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly IPropertiesService propertiesService;

        public PropertiesController(IPropertiesService propertiesService)
        {
            this.propertiesService = propertiesService;
        }
        public IActionResult Index(int page = 1)
        {
            PropertiesViewModel model = propertiesService.GetProperties(page);
            return View(model);
        }

        public IActionResult SearchByPrice(int minPrice, int maxPrice, int page = 1)
        {
            if (minPrice != 0 && maxPrice != 0)
            {
                SearchPropertiesViewModel model = propertiesService.SearchByPrice(minPrice, maxPrice, page);
                return View(model);
            }
            else
            {
                return View();
            }

        }

    }
}
