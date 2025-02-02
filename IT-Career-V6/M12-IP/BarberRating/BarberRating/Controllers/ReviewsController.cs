using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarberRating.Data;
using BarberRating.Data.Models;
using BarberRating.ViewModels.Reviews;
using BarberRating.Services.Contracts;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace BarberRating.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IReviewsService reviewsService;

        public ReviewsController(ApplicationDbContext context, IReviewsService reviewsService)
        {
            _context = context;
            this.reviewsService = reviewsService;
        }

        // GET: Reviews
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reviews.Include(r => r.Barber).Include(r => r.User);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> UserIndex(IndexReviewsUserViewModel userReviews)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            userReviews = await reviewsService.GetUserReviewsAsync(userReviews, userId);

            return View(userReviews);
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Barber)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        public IActionResult Create(string barberId)
        {
            CreateReviewViewModel model = new CreateReviewViewModel();
            model.BarberId = barberId;
            return View(model);
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateReviewViewModel review)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                await reviewsService.CreateReviewAsync(review, userId);
                return RedirectToAction(nameof(UserIndex));
            }

            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            ViewData["BarberId"] = new SelectList(_context.Barbers, "Id", "Id", review.BarberId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", review.UserId);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserId,BarberId,Rating,ReviewText")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
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
            ViewData["BarberId"] = new SelectList(_context.Barbers, "Id", "Id", review.BarberId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", review.UserId);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Barber)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(string id)
        {
            return _context.Reviews.Any(e => e.Id == id);
        }
    }
}
