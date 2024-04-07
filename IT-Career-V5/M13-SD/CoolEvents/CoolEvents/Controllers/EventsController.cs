using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoolEvents.Data;
using CoolEvents.Data.Models;
using CoolEvents.ViewModels.Events;
using CoolEvents.Services.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace CoolEvents.Controllers
{
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
        public async Task<IActionResult> Index(IndexEventsViewModel? model)
        {
            if (model == null)
            {
                model = new IndexEventsViewModel();
            }
            model = await eventsService.GetEventsAsync(model);

            return View(model);
        }

        [Authorize(Roles =GlobalConstants.AdminRole)]
        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Create(CreateEventViewModel @event)
        {
            if (ModelState.IsValid)
            {
                await eventsService.CreateEventAsync(@event);
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Description,Image,PremiereDate")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var @event = await _context.Events.FindAsync(id);
            if (@event != null)
            {
                _context.Events.Remove(@event);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = GlobalConstants.AdminRole)]
        private bool EventExists(string id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
