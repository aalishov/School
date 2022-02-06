namespace P05_Eventures.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Contracts;
    using ViewModels.Events;

    public class EventsController : Controller
    {
        private readonly IEventsService eventsService;

        public EventsController(IEventsService eventsService)
        {
            this.eventsService = eventsService;
        }

        // GET: Events
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(await eventsService.GetAllEventsAsync(page));
        }

        // GET: Events
        public async Task<IActionResult> UserIndex(int page = 1)
        {
            return View(await eventsService.GetAllEventsForUserAsync(page));
        }
        [Authorize]
        public async Task<IActionResult> Order(string id, int count)
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await eventsService.OrderAsync(id, count, userId);
            return RedirectToAction(nameof(UserIndex));
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await eventsService.GetEventAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateEventViewModel model)
        {
            if (ModelState.IsValid)
            {
                await eventsService.CreateEventAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await eventsService.GetEventForEdit(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditEventViewModel @event)
        {
            if (ModelState.IsValid)
            {
                await eventsService.EditEventAsync(@event);

                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        //// GET: Events/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var @event = await _context.Events
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (@event == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(@event);
        //}

        //// POST: Events/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var @event = await _context.Events.FindAsync(id);
        //    _context.Events.Remove(@event);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EventExists(string id)
        //{
        //    return _context.Events.Any(e => e.Id == id);
        //}
    }
}
