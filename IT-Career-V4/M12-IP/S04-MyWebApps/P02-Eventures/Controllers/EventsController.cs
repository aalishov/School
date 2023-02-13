using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P02_Eventures.Data;
using P02_Eventures.Data.Models;
using P02_Eventures.Services;
using P02_Eventures.ViewModels;
using P02_Eventures.ViewModels.Events;

namespace P02_Eventures.Controllers
{

    [Authorize(Roles = "Admin,Customer")]
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEventsService eventsService;

        public EventsController(ApplicationDbContext context, IEventsService eventsService)
        {
            _context = context;
            this.eventsService = eventsService;
        }

        // GET: Events
        public async Task<IActionResult> Index(string place = null, int page = 1)
        {
            var model = await eventsService.GetEventsAsync(place, page);
            return View(model);
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await eventsService.GetEventDetailsById(id);

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
        public async Task<IActionResult> Create(CreateEventViewModel @event)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this.eventsService.CreateEventAsync(@event);
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Error", "Home", new ErrorViewModel() { ErrorMessage = ex.Message });
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await this.eventsService.GetEventEditViewModelByIdAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditEventViewModel @event)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this.eventsService.UpdateEventAsync(@event);
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Error", "Home", new ErrorViewModel() { ErrorMessage = ex.Message });
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await this.eventsService.GetEventDetailsById(id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            try
            {
                await this.eventsService.DeleteEventByIdAsync(id);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home", new ErrorViewModel() { ErrorMessage = ex.Message });
            };
            return RedirectToAction(nameof(Index));
        }
    }
}
