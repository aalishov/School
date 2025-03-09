using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VacationManagerWebApp.Data;
using VacationManagerWebApp.Data.Models;
using VacationManagerWebApp.Services.Contracts;
using VacationManagerWebApp.ViewModels.Leaves;

namespace VacationManagerWebApp.Controllers
{
    public class LeavesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILeavesService service;

        public LeavesController(ApplicationDbContext context, ILeavesService service)
        {
            _context = context;
            this.service = service;
        }

        // GET: Leaves
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Leaves.Include(l => l.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Leaves/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leave = await _context.Leaves
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leave == null)
            {
                return NotFound();
            }

            return View(leave);
        }
        // GET: Leaves/CreateSick
        public IActionResult CreateSick()
        {
            ViewData["UserId"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View();
        }

        // POST: Leaves/CreateSick
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSick(CreateSickLeaveViewModel leave)
        {
            if (ModelState.IsValid)
            {
                await service.CreateSickLeaveAsync(leave);
                return RedirectToAction(nameof(Index));
            }
            return View(leave);
        }

        // GET: Leaves/CreateUnpaid
        public IActionResult CreateUnpaid()
        {
            ViewData["UserId"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View();
        }

        // POST: Leaves/CreateUnpaid
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUnpaid(CreateUnpaidLeaveViewModel leave)
        {
            if (ModelState.IsValid)
            {
                await service.CreateUnPaidLeaveAsync(leave);
                return RedirectToAction(nameof(Index));
            }
            return View(leave);
        }


        // GET: Leaves/CreatePaid
        public IActionResult CreatePaid()
        {
            ViewData["UserId"] = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View();
        }

        // POST: Leaves/CreatePaid
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePaid(CreatePaidLeaveViewModel leave)
        {
            if (ModelState.IsValid)
            {
                await service.CreatePaidLeaveAsync(leave);
                return RedirectToAction(nameof(Index));
            }
            return View(leave);
        }


        // GET: Leaves/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Leaves/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,StartDate,EndDate,CreateDate,HalfDay,Approved,UserId,File")] Leave leave)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leave);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", leave.UserId);
            return View(leave);
        }

        // GET: Leaves/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leave = await _context.Leaves.FindAsync(id);
            if (leave == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", leave.UserId);
            return View(leave);
        }

        // POST: Leaves/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Type,StartDate,EndDate,CreateDate,HalfDay,Approved,UserId,File")] Leave leave)
        {
            if (id != leave.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leave);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveExists(leave.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", leave.UserId);
            return View(leave);
        }

        // GET: Leaves/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leave = await _context.Leaves
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leave == null)
            {
                return NotFound();
            }

            return View(leave);
        }

        // POST: Leaves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var leave = await _context.Leaves.FindAsync(id);
            if (leave != null)
            {
                _context.Leaves.Remove(leave);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveExists(string id)
        {
            return _context.Leaves.Any(e => e.Id == id);
        }
    }
}
