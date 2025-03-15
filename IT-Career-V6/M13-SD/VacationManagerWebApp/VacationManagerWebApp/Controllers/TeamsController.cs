using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VacationManagerWebApp.Data;
using VacationManagerWebApp.Data.Models;
using VacationManagerWebApp.Services.Contracts;
using VacationManagerWebApp.ViewModels.Teams;

namespace VacationManagerWebApp.Controllers
{
    [Authorize]
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITeamsService service;

        public TeamsController(ApplicationDbContext context, ITeamsService service)
        {
            _context = context;
            this.service = service;
        }

        // GET: Teams
        public async Task<IActionResult> Index(IndexTeamsViewModel? model)
        {
            model = await service.GetTeamsAsync(model);
            return View(model);
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await service.GetTeamDetailsAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // GET: Teams/AddTeamLead
        public async Task<IActionResult> AddTeamLead(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await service.GetTeamToAddTeamLeadAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/AddTeamLead
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTeamLead(AddTeamLeadViewModel team)
        {
            if (ModelState.IsValid)
            {
                await service.AddTeamLeadAsync(team);
                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }

        // GET: Teams/AddProject
        public async Task<IActionResult> AddProject(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await service.GetTeamToAddProject(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/AddProject
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProject(AddProjectViewModel team)
        {
            if (ModelState.IsValid)
            {
                await service.AddProjectAsync(team);
                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }
        // GET: Teams/AddDeveloper
        public async Task<IActionResult> AddDeveloper(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await service.GetTeamToAddDeveloperAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/AddDeveloper
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDeveloper(AddDeveloperViewModel team)
        {
            if (ModelState.IsValid)
            {
                string teamId = await service.AddDeveloperAsync(team);
                return RedirectToAction(nameof(Details), new RouteValueDictionary() { { "id", teamId } });
            }
            return View(team);
        }


        // GET: Teams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTeamViewModel team)
        {
            if (ModelState.IsValid)
            {
                await service.CreateTeamAsync(team);
                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }

        // GET: Teams/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", team.ProjectId);
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,TeamLeadId,ProjectId")] Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(team);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(team.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", team.ProjectId);
            return View(team);
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team != null)
            {
                _context.Teams.Remove(team);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(string id)
        {
            return _context.Teams.Any(e => e.Id == id);
        }

        public async Task<IActionResult> RemoveDeveloper(string id)
        {
            string teamId = await service.RemoveDeveloper(id);

            if (teamId == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Details), new RouteValueDictionary() { { "id", teamId } });
        }
    }
}
