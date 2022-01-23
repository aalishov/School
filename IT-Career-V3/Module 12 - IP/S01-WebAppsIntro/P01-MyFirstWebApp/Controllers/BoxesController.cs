using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P01_MyFirstWebApp.Data;
using P01_MyFirstWebApp.Data.Models;
using P01_MyFirstWebApp.Models.Boxes;
using P01_MyFirstWebApp.Models.Items;

namespace P01_MyFirstWebApp.Controllers
{
    public class BoxesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BoxesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Boxes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Boxes.Include(b => b.Color);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Boxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var box = await _context.Boxes
                .Include(b => b.Color)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (box == null)
            {
                return NotFound();
            }

            return View(box);
        }

        // GET: Boxes/Create
        public IActionResult Create()
        {
            ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Name");
            return View();
        }

        // POST: Boxes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Width,Height,MaxCapacity,ColorId")] Box box)
        {
            if (ModelState.IsValid)
            {
                _context.Add(box);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Name", box.ColorId);
            return View(box);
        }

        // GET: Boxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var box = await _context.Boxes.FindAsync(id);
            if (box == null)
            {
                return NotFound();
            }
            ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Name", box.ColorId);
            return View(box);
        }

        // POST: Boxes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Width,Height,MaxCapacity,ColorId")] Box box)
        {
            if (id != box.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(box);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoxExists(box.Id))
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
            ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Name", box.ColorId);
            return View(box);
        }

        // GET: Boxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var box = await _context.Boxes
                .Include(b => b.Color)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (box == null)
            {
                return NotFound();
            }

            return View(box);
        }

        // POST: Boxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var box = await _context.Boxes.FindAsync(id);
            _context.Boxes.Remove(box);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> GetNotFullBoxes()
        {
            List<JsonBoxViewModel> boxes = await _context.Boxes
                .Where(x => x.Items.Count < x.MaxCapacity)
                .Select(x => new JsonBoxViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Color = x.Color.Name,
                    MaxCapacity = x.MaxCapacity,
                    CurentCapacity = x.Items.Count,
                    Items = x.Items.Select(i => new JsonItemViewModel()
                    {
                        Id = i.Id,
                        Name=i.Name,
                        Color = i.Color.Name
                    }).ToList()
                })
                .ToListAsync();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            return Json(boxes, options);
        }

        private bool BoxExists(int id)
        {
            return _context.Boxes.Any(e => e.Id == id);
        }
    }
}
