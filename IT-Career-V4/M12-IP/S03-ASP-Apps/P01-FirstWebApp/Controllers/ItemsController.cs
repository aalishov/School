using Microsoft.AspNetCore.Mvc;
using P01_FirstWebApp.ViewModels.Items;

namespace P01_FirstWebApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            IndexVM model= new IndexVM();
            return View(model);
        }
    }
}
