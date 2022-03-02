using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pizza.Data;
using Pizza.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Order()
        {
            OrderViewModel model = new OrderViewModel();
            model.AppPizzas = new SelectList(context.AppPizzas.ToList(),"Id","Name");
            return View(model);
        }
    }
}
