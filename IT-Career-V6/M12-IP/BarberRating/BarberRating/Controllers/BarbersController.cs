using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarberRating.Data;
using BarberRating.Data.Models;
using BarberRating.ViewModels.Barbers;
using BarberRating.Services.Contracts;

namespace BarberRating.Controllers
{
    public class BarbersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBarbersService barbersService;

        public BarbersController(ApplicationDbContext context, IBarbersService barbersService)
        {
            _context = context;
            this.barbersService = barbersService;
        }

        // GET: Barbers
        public async Task<IActionResult> Index(IndexBarbersViewModel barbers)
        {
            barbers = await barbersService.GetBarbersAsync(barbers);
            return View(barbers);
        }

        // GET: Barbers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barber = await _context.Barbers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (barber == null)
            {
                return NotFound();
            }

            return View(barber);
        }

        // GET: Barbers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Barbers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBarberViewModel barber)
        {
            if (ModelState.IsValid)
            {
                await barbersService.CreateBarberAsync(barber);
                return RedirectToAction(nameof(Index));
            }
            return View(barber);
        }

        // GET: Barbers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barber = await barbersService.GetBarberToEditAsync(id);
            if (barber == null)
            {
                return NotFound();
            }
            return View(barber);
        }

        // POST: Barbers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditBarberViewModel editBarber)
        {

            if (ModelState.IsValid)
            {
                await barbersService.UpdateBarberAsync(editBarber);
                return RedirectToAction(nameof(Index));
            }
            return View(editBarber);
        }

        // GET: Barbers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barber = await _context.Barbers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (barber == null)
            {
                return NotFound();
            }

            return View(barber);
        }

        // POST: Barbers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var barber = await _context.Barbers.FindAsync(id);
            if (barber != null)
            {
                _context.Barbers.Remove(barber);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BarberExists(string id)
        {
            return _context.Barbers.Any(e => e.Id == id);
        }
    }
}
