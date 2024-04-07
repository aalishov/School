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
using CoolEvents.ViewModels.Tickets;
using System.Security.Claims;
using CoolEvents.Services.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace CoolEvents.Controllers
{
    [Authorize]
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITicketsService ticketsService;

        public TicketsController(ApplicationDbContext context, ITicketsService ticketsService)
        {
            _context = context;
            this.ticketsService = ticketsService;
        }

        // GET: Tickets
        public async Task<IActionResult> Index(IndexTicketsViewModel model)
        {
            if (!this.User.IsInRole(GlobalConstants.AdminRole))
            {
                model.LoggedUserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
            else
            {
                model.LoggedUserId = null;
            }
            model = await ticketsService.GetTicketsAsync(model);
            return View(model);
        }


        // GET: Tickets/Create
        public async Task<IActionResult> Create(string eventId)
        {
            CreateTicketViewModel model = await ticketsService.GetCreateViewModelInfoAsync(eventId);
            model.UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View(model);
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTicketViewModel model)
        {
            if (ModelState.IsValid)
            {
                await ticketsService.CreateTicketAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

      
        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.Event)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(string id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
